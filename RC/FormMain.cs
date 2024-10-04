using Neo4j.Driver;
using Neo4jClient.Cypher;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing.Imaging;
using System.Reflection;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RC
{
    public partial class FormMain : Form
    {
        public string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName; // đường dẫn đến mục sản phẩm
        private FlowLayoutPanel _productPanel;
        private FlowLayoutPanel _allProductPanel;
        public string email = "";
        private FlowLayoutPanel _categoryPanel;
        private FlowLayoutPanel _brandPanel;
        private Neo4jConnection _connection;
        public FormMain()
        {
            InitializeComponent();
            _connection = new Neo4jConnection("bolt://localhost:7687", "neo4j", "123456789", this);
            InitializeUI();
        }

        public FormMain(string kh)
        {
            InitializeComponent();
            _connection = new Neo4jConnection("bolt://localhost:7687", "neo4j", "123456789", this);
            InitializeUI();
            email = kh;
        }

        private void InitializeUI()
        {
            _productPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                AutoScroll = true,
                Height = 230
            };
            PN1.Controls.Add(_productPanel);


            _categoryPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                AutoScroll = true,
                Height = 230
            };
            PN3.Controls.Add(_categoryPanel);

            _brandPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                AutoScroll = true,
                Height = 230
            };
            PN2.Controls.Add(_brandPanel);

            _allProductPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                AutoScroll = true,
                Height = 230
            };
            PN4.Controls.Add(_allProductPanel);

         
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await LoadProducts(null, 0); //all pro vao panel pro
            await LoadCategorys();
            await LoadBrands();
            await LoadProducts(email, 1); //recom ve just for u


        }

        public async Task LoadProducts(string e, int loai) // có e là trả về recom, loai = 0:them vào panel product-----1:la just for u
        {
            try
            {
                _productPanel.Controls.Clear();
                var products = await _connection.GetProductsAsync(e);
                foreach (var product in products)
                {
                    AddProductToPanel(product, loai);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        ///////////////////////////////////////////////////// cate
        private async Task LoadCategorys()
        {
            try
            {
                cbo_Category.Items.Clear(); // categoryComboBox là tên của ComboBox mà bạn đã thiết kế sẵn
                var categories = await _connection.GetCategory();
                foreach (var category in categories)
                {
                    cbo_Category.Items.Add(category.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
            cbo_Category.Items.Insert(0, "All");
        }

        private async Task LoadBrands()
        {
            try
            {
                cbo_Brand.Items.Clear(); // categoryComboBox là tên của ComboBox mà bạn đã thiết kế sẵn
                var brands = await _connection.GetBrand();
                foreach (var brand in brands)
                {
                    cbo_Brand.Items.Add(brand.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
            cbo_Brand.Items.Insert(0, "All");
        }

        private void AddBrandToPanel(Brand brand)
        {
            PictureBox pictureBox = new PictureBox
            {
                Width = 100,
                Height = 100,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = LoadImage(brand.Image) ?? null,
                Margin = new Padding(5),
            };
            pictureBox.Tag = brand.Name;
            pictureBox.Click += PictureBox_Click;

            Label nameLabel = new Label
            {
                Text = brand.Name,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 100
            };

            Panel brandPanel = new Panel
            {
                Width = 110,
                Height = 130
            };
            brandPanel.Controls.Add(pictureBox);
            brandPanel.Controls.Add(nameLabel);
            nameLabel.Location = new System.Drawing.Point(0, 105);

            _brandPanel.Controls.Add(brandPanel);
        }

        private void AddCategoryToPanel(Category category)
        {
            PictureBox pictureBox = new PictureBox
            {
                Width = 100,
                Height = 100,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = LoadImage(category.Image, category) ?? null,
                Margin = new Padding(5)
            };
            pictureBox.Tag = category.Name;
            pictureBox.Click += PictureBox_Click;

            Label nameLabel = new Label
            {
                Text = category.Name,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 100
            };

            Panel categoryPanel = new Panel
            {
                Width = 110,
                Height = 130
            };
            categoryPanel.Controls.Add(pictureBox);
            categoryPanel.Controls.Add(nameLabel);
            nameLabel.Location = new System.Drawing.Point(0, 105);

            _categoryPanel.Controls.Add(categoryPanel);
        }
        //////////////////Click image
        private async void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                string productName = pictureBox.Tag as string;
                if (!string.IsNullOrEmpty(productName))
                {
                    _connection.HandleProductClickAsync(productName, email);

                }
            }
        }
        /////////////////////////////

        private void AddProductToPanel(Product product, int loai)
        {
            PictureBox pictureBox = new PictureBox
            {
                Width = 180, // Increase the width of the product image
                Height = 180, // Increase the height of the product image
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = LoadImage(product.Image) ?? null,
                Margin = new Padding(5)
            };
            pictureBox.Tag = product.Name;
            pictureBox.Click += PictureBox_Click;

            Label nameLabel = new Label
            {
                Text = product.Name,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 180 // Match the width of the product image
            };

            Panel productPanel = new Panel
            {
                Width = 190, // Set the width slightly larger to accommodate padding/margin
                Height = 220 // Increase the height to fit both the image and the label comfortably
            };
            productPanel.Controls.Add(pictureBox);
            productPanel.Controls.Add(nameLabel);
            nameLabel.Location = new System.Drawing.Point(0, 185); // Place the label below the image

            if (loai == 0) // chung
            {
                _allProductPanel.Controls.Add(productPanel);
            }
            else // recom
            {
                _productPanel.Controls.Add(productPanel);
            }
        }


        private Image LoadImage(string imagePath, object entity = null)
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        Image image = Image.FromStream(stream);
                        if (entity != null)
                        {
                            if (entity is Product p)
                            {
                                image.Tag = p.Name;
                            }
                            else if (entity is Brand b)
                            {
                                image.Tag = b.Name;
                            }
                            else if (entity is Category c)
                            {
                                image.Tag = c.Name;
                            }
                        }
                        return image;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
            return null;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _connection.Dispose();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void PN2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void PN3_Paint(object sender, PaintEventArgs e)
        {

        }
        private async Task FilterProducts(string brand, string category)
        {
            try
            {
                _allProductPanel.Controls.Clear(); // Xóa các sản phẩm hiện tại để hiển thị kết quả lọc mới

                // Nếu cả hai đều là "All", lấy tất cả sản phẩm
                if (brand == "All" && category == "All")
                {
                    var allProducts = await _connection.GetFilteredProductsAsync(null, null); // Hoặc có thể gọi một hàm khác lấy tất cả sản phẩm
                    foreach (var product in allProducts)
                    {
                        AddProductToPanel(product, 0); // Thêm sản phẩm vào panel
                    }
                }
                else if (brand == "All" || category == "All") // Nếu chỉ có một cái là "All"
                {
                    // Nếu brand là "All", thì chỉ lọc theo category
                    string filteredBrand = brand == "All" ? null : brand;
                    string filteredCategory = category == "All" ? null : category;

                    var filteredProducts = await _connection.GetFilteredProductsAsync(filteredBrand, filteredCategory);
                    foreach (var product in filteredProducts)
                    {
                        AddProductToPanel(product, 0); // Thêm sản phẩm vào panel
                    }
                }
                else // Nếu cả hai đều có giá trị cụ thể
                {
                    var filteredProducts = await _connection.GetFilteredProductsAsync(brand, category);
                    foreach (var product in filteredProducts)
                    {
                        AddProductToPanel(product, 0); // Thêm sản phẩm vào panel
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }
        private async void btn_Loc_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedBrand = cbo_Brand.SelectedItem?.ToString();
                string selectedCategory = cbo_Category.SelectedItem?.ToString();

                // Kiểm tra xem có cần yêu cầu người dùng chọn không
                if (selectedBrand == "All" && selectedCategory == "All")
                {
                    // Nếu cả hai đều là "All", thì chỉ cần gọi để lấy tất cả sản phẩm
                    await FilterProducts("All", "All");
                }
                else if (selectedBrand == null && selectedCategory == null)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một tiêu chí để lọc.");
                }
                else
                {
                    // Chuyển đổi giá trị "All" thành null để gọi hàm lọc
                    string brand = selectedBrand == "All" ? "All" : selectedBrand;
                    string category = selectedCategory == "All" ? "All" : selectedCategory;

                    await FilterProducts(brand, category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txt_TimKiem.Text.Trim(); // Lấy từ người dùng nhập vào
                if (!string.IsNullOrWhiteSpace(searchTerm)) // Kiểm tra nếu người dùng đã nhập
                {
                    var searchedProducts = await _connection.GetSearchedProductsAsync(searchTerm);
                    _allProductPanel.Controls.Clear(); // Xóa sản phẩm hiện tại
                    foreach (var product in searchedProducts)
                    {
                        AddProductToPanel(product, 0); // Thêm sản phẩm tìm kiếm vào panel
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }
        private async Task RefreshProducts()
        {
            try
            {
                // Reset các ComboBox về giá trị "All"
                cbo_Brand.SelectedItem = "All";
                cbo_Category.SelectedItem = "All";

                // Xóa nội dung tìm kiếm
                txt_TimKiem.Text = string.Empty;

                // Gọi hàm để lấy tất cả sản phẩm
                var allProducts = await _connection.GetFilteredProductsAsync(null, null);

                // Hiển thị tất cả sản phẩm
                _allProductPanel.Controls.Clear(); // Xóa các sản phẩm hiện tại
                foreach (var product in allProducts)
                {
                    AddProductToPanel(product, 0); // Thêm sản phẩm vào panel
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void btn_Refesh_Click(object sender, EventArgs e)
        {
            await RefreshProducts();
        }
    }








    public class Neo4jConnection : IDisposable
    {
        public readonly IDriver _driver;
        public FormMain f;



        public Neo4jConnection(string uri, string user, string password, FormMain ff=null)
        {
            f = ff;
            _driver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));
        }
        //
        public async Task<List<Product>> GetSearchedProductsAsync(string searchTerm)
        {
            await using var session = _driver.AsyncSession();
            return await session.ReadTransactionAsync(async tx =>
            {
                string query = "MATCH (p:Product) " +
                        "WHERE toLower(p.name) CONTAINS toLower($searchTerm) " + // Sử dụng toLower() để so sánh không phân biệt chữ hoa chữ thường
                        "RETURN p.name AS name, p.image AS image";

                var parameters = new { searchTerm };
                var result = await tx.RunAsync(query, parameters);
                var products = new List<Product>();
                await foreach (var record in result)
                {
                    string name = record["name"].As<string>();
                    string image = record["image"].As<string>();
                    products.Add(new Product(name, image));
                }

                return products;
            });
        }

        public async Task<List<Product>> GetFilteredProductsAsync(string brand, string category)
        {
            await using var session = _driver.AsyncSession();
            return await session.ReadTransactionAsync(async tx =>
            {
                string query = "MATCH (p:Product)-[:MADE_BY]->(b:Brand), (p)-[:IN_CATEGORY]->(c:Category) " +
                      "WHERE ($brand IS NULL OR b.name = $brand) " + // Nếu brand là null thì bỏ qua điều kiện này
                      "AND ($category IS NULL OR c.name = $category) " + // Nếu category là null thì bỏ qua điều kiện này
                      "RETURN p.name AS name, p.image AS image";


                var parameters = new { brand, category };
                var result = await tx.RunAsync(query, parameters);
                var products = new List<Product>();
                await foreach (var record in result)
                {
                    string name = record["name"].As<string>();
                    string image = record["image"].As<string>();
                    products.Add(new Product(name, image));
                }

                return products;
            });
        }


        //
        public async Task<List<Product>> GetProductsAsync(string email)
        {
            await using var session = _driver.AsyncSession();

            // Nếu email không có, lấy tất cả sản phẩm
            if (string.IsNullOrEmpty(email))
            {
                return await session.ReadTransactionAsync(async tx =>
                {
                    var result = await tx.RunAsync("MATCH (p:Product) RETURN p.name AS name, p.image AS image");
                    var products = new List<Product>();
                    await foreach (var record in result)
                    {
                        string name = record["name"].As<string>();
                        string image = record["image"].As<string>();
                        products.Add(new Product(name, image));
                    }
                    return products;
                });
            }
            else // Nếu có email, gợi ý sản phẩm
            {
                return await session.ReadTransactionAsync(async tx =>
                {
                    // Truy vấn để tìm sản phẩm khách hàng đã mua
                    var purchasedQuery = @"
                MATCH (a:Customer {email: $email})-[:BUY]->(p:Product)
                RETURN COLLECT({name: p.name, image: p.image}) AS purchasedProducts";

                    var purchasedResult = await tx.RunAsync(purchasedQuery, new { email });
                    var purchasedProducts = new List<Product>();

                    if (await purchasedResult.FetchAsync())
                    {
                        var products = purchasedResult.Current["purchasedProducts"].As<List<Dictionary<string, object>>>();
                        foreach (var product in products)
                        {
                            string name = product["name"].ToString();
                            string image = product["image"].ToString();
                            purchasedProducts.Add(new Product(name, image));
                        }
                    }

                    // Truy vấn để tìm sản phẩm gợi ý từ các loại và thương hiệu mà khách hàng chưa mua
                    var suggestionQuery = @"
                MATCH (a:Customer {email: $email})
                MATCH (p:Product)
                WHERE NOT (p)-[:IN_CATEGORY]->(:Category)<-[:BUY]-(a) 
                AND NOT (p)-[:BELONGS_TO]->(:Brand)<-[:BUY]-(a)
                RETURN p.name AS name, p.image AS image
                ORDER BY rand() LIMIT 10";

                    var suggestionResult = await tx.RunAsync(suggestionQuery, new { email });
                    var suggestedProducts = new List<Product>();

                    await foreach (var record in suggestionResult)
                    {
                        string name = record["name"].As<string>();
                        string image = record["image"].As<string>();
                        suggestedProducts.Add(new Product(name, image));
                    }

                    // Kết hợp các sản phẩm đã mua và sản phẩm gợi ý
                    suggestedProducts.AddRange(purchasedProducts);

                    return suggestedProducts.Distinct().ToList(); // Trả về danh sách sản phẩm mà không trùng lặp
                });
            }
        }






        // đếm số lần mua hàng
        public async Task<int> GetCustomerPurchaseCount(string email)
        {
            await using var session = _driver.AsyncSession();
            return await session.ReadTransactionAsync(async tx =>
            {
                var query = @"
            MATCH (c:Customer {email: $email})-[:BUY]->(p:Product)
            RETURN COUNT(DISTINCT p) AS purchaseCount
        ";

                var result = await tx.RunAsync(query, new { email });
                var record = await result.SingleAsync();
                return record["purchaseCount"].As<int>();
            });
        }

        /*return await session.ReadTransactionAsync(async tx =>
                {
            var result = await tx.RunAsync("match(a:Customer{email:'" + form.email + "'}),(b:Product)where (a)-[:BUY]->(b) return b.name");


            var products = new List<Product>();
            await foreach (var record in result)
            {
                string name = record["name"].As<string>();
                string image = record["image"].As<string>();
                products.Add(new Product(name, image));
            }
            return products;
        });*/
        //lấy toàn bộ category
        public async Task<List<Category>> GetCategory()
        {
            await using var session = _driver.AsyncSession();
            return await session.ReadTransactionAsync(async tx =>
            {
                var result = await tx.RunAsync("MATCH (c:Category) RETURN c.name AS name, c.image AS image");
                var categorys = new List<Category>();
                await foreach (var record in result)
                {
                    string name = record["name"].As<string>();
                    string image = record["image"].As<string>();
                    categorys.Add(new Category(name, image));
                }
                return categorys;
            });
        }
        //lấy toàn bộ brand
        public async Task<List<Brand>> GetBrand()
        {
            await using var session = _driver.AsyncSession();
            return await session.ReadTransactionAsync(async tx =>
            {
                var result = await tx.RunAsync("MATCH (b:Brand) RETURN b.name AS name, b.image AS image");
                var brands = new List<Brand>();
                await foreach (var record in result)
                {
                    string name = record["name"].As<string>();
                    string image = record["image"].As<string>();
                    brands.Add(new Brand(name, image));
                }
                return brands;
            });
        }
        // truy vấn lấy sản phẩm liên quan từ product
        public async Task<List<Product>> GetSameCategoryFromP(Product p)
        {
            await using var session = _driver.AsyncSession();
            return await session.ReadTransactionAsync(async tx =>
            {
                var result = await tx.RunAsync(
                    "MATCH (a:Product {name: $name})-[:IN_CATEGORY]->(b:Category) RETURN b.name AS name",
                    new { name = p.Name });// truyền tên sản phẩm để lấy category
                var record1 = await result.SingleAsync(); // nhận 1 bản ghi
                
                
                var result2 = await tx.RunAsync(
                    "MATCH (a:Product)-[:IN_CATEGORY]->(b:Category{name: $name}) return a.name AS name, a.image AS image",
                    new { name = record1["name"].As<string>() });

                var products = new List<Product>();
                await foreach (var record in result2)
                {
                    string name = record["name"].As<string>();
                    string image = record["image"].As<string>();
                    products.Add(new Product(name, image));
                }
                return products;
            });
        }

        // ko thêm trùng product vào list
        public async Task checkP(Product p)
        {
            await using var session = _driver.AsyncSession();
            var product = await session.ReadTransactionAsync(async tx =>
            {
                var result = await tx.RunAsync(
                    "MATCH (p:Product {name: $name}) " +
                    "RETURN p.name AS name, p.image AS image, p.price AS price, p.description AS description",
                    new { name = p.Name });

                var record = await result.SingleAsync();

                return false;
            });
        }


        // sự kiện click img
        // sản phẩm
        public async Task HandleProductClickAsync(string productName, string e)
        {
            await using var session = _driver.AsyncSession();
            var product = await session.ReadTransactionAsync(async tx =>
            {
                var result = await tx.RunAsync(
                    "MATCH (p:Product {name: $name}) " +
                    "RETURN p.name AS name, p.image AS image, p.price AS price, p.description AS description",
                    new { name = productName });

                var record = await result.SingleAsync();
                return new Product(
                    record["name"].As<string>(),
                    record["image"].As<string>(),
                    record["description"].As<string>(),
                    record["price"].As<decimal>()
                    
                );
            });

            UpdateUI(product, e);
        }

        private void UpdateUI(Product product, string email)
        {
            FormProductDetail productDetail = new FormProductDetail(product, email,f);
            productDetail.StartPosition = FormStartPosition.Manual;
            productDetail.Location = new System.Drawing.Point(100, 100);
            productDetail.ShowDialog();
        }
        // sự kiện click buy
        public async Task HandleBuyClickAsync(string productName, string email, int amount)
        {
            await using var session = _driver.AsyncSession();
            await session.WriteTransactionAsync(async tx =>
            {
                var query = @"
            MATCH (a:Customer {email: $email}), (b:Product {name: $name})
            CREATE (a)-[c:BUY {amount: $amount}]->(b)
        ";

                var parameters = new
                {
                    email,
                    name = productName,
                    amount
                };

                await tx.RunAsync(query, parameters);
            });
        }
        // load brand và cate
        public async Task<List<string>> GetBrandNamesAsync()
        {
            var query = "MATCH (b:Brand) RETURN b.name AS Name ORDER BY b.name";
            return await ExecuteQueryAndGetNamesAsync(query);
        }

        public async Task<List<string>> GetCategoryNamesAsync()
        {
            var query = "MATCH (c:Category) RETURN c.name AS Name ORDER BY c.name";
            return await ExecuteQueryAndGetNamesAsync(query);
        }

        private async Task<List<string>> ExecuteQueryAndGetNamesAsync(string query)
        {
            var names = new List<string>();
            await using var session = _driver.AsyncSession();
            try
            {
                var result = await session.ReadTransactionAsync(async tx =>
                {
                    var cursor = await tx.RunAsync(query);
                    return await cursor.ToListAsync();
                });

                foreach (var record in result)
                {
                    names.Add(record["Name"].As<string>());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                // Có thể thêm xử lý lỗi khác ở đây nếu cần
            }
            return names;
        }
        //////////////////////////////
        /// thêm product
        public async Task<bool> AddProductAsync(string name, string image, string price, string amount, string categoryName, string brandName, string description)
        {
            var query = @"
                MATCH (c:Category {name: $categoryName})
                MATCH (b:Brand {name: $brandName})
                CREATE (p:Product {
                    name: $name,
                    image: $image,
                    price: $price,
                    amount: $amount,
                    description: $description
                })
                CREATE (p)-[:IN_CATEGORY]->(c)
                CREATE (p)-[:MADE_BY]->(b)
                WITH p, b
                MATCH (otherProduct:Product)-[:MADE_BY]->(b)
                WHERE otherProduct <> p
                CREATE (p)-[:SAME_BRAND]->(otherProduct)
                RETURN p";

            var parameters = new
            {
                name,
                image,
                price,
                amount,
                categoryName,
                brandName,
                description
            };

            try
            {
                await using var session = _driver.AsyncSession();
                var result = await session.WriteTransactionAsync(async tx =>
                {
                    var cursor = await tx.RunAsync(query, parameters);
                    var summary = await cursor.ConsumeAsync(); // Kiểm tra tổng số bản ghi được tạo
                    return summary.Counters.NodesCreated > 0; // Trả về true nếu có bản ghi được tạo
                });

               

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding product: {ex.Message}");
                MessageBox.Show($"Thêm sản phẩm thất bại: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// thêm brand
        public async Task<bool> AddBrandAsync(string name, string image)
        {
            var query = @"
            CREATE (b:Brand {
                name: $name,
                image: $image
            })
            RETURN b";

            var parameters = new
            {
                name,
                image
            };

            try
            {
                await using var session = _driver.AsyncSession();
                var result = await session.WriteTransactionAsync(async tx =>
                {
                    var cursor = await tx.RunAsync(query, parameters);
                    return await cursor.SingleAsync();
                });
                MessageBox.Show("Thêm thành công");
                return result != null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding brand: {ex.Message}");
                return false;
            }
        }
        /// thêm cate
        public async Task<bool> AddCateAsync(string name, string image)
        {
            var query = @"
            CREATE (c:Category {
                name: $name,
                image: $image
            })
            RETURN c";

            var parameters = new
            {
                name,
                image
            };

            try
            {
                await using var session = _driver.AsyncSession();
                var result = await session.WriteTransactionAsync(async tx =>
                {
                    var cursor = await tx.RunAsync(query, parameters);
                    return await cursor.SingleAsync();
                });
                MessageBox.Show("Thêm thành công");
                return result != null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding category: {ex.Message}");
                return false;
            }
        }
        public void Dispose()
        {
            _driver?.Dispose();
        }
    }

    public class Product
    {
        //public string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName; // đường dẫn đến mục sản phẩm cách 1 (lấy từ thư mục bin)
        public string projectDirectory = GetSiblingDirectory("SP"); // đường dẫn đến mục sản phẩm (lấy từ chính thư mục SP trong project)
        public string Name { get; }
        public string Description { get; }
        public string Image { get; }
        public decimal Price { get; }
        // lấy đường dẫn đến thư mục sản phẩm cách 2 (tôi chưa tối ưu cái phương thức này)
        public static string GetSiblingDirectory(string folderName)
        {
            string executingAssemblyPath = Assembly.GetExecutingAssembly().Location;
            string binDirectory = Path.GetDirectoryName(executingAssemblyPath);
            string projectDirectory = Directory.GetParent(binDirectory).FullName;
            string a = Directory.GetParent(projectDirectory).FullName;
            string b = Directory.GetParent(a).FullName;
            string siblingDirectory = Path.Combine(b, folderName);
            return siblingDirectory;
        }

        // xoá dấu nháy
        public string RemoveQuotes(string input)
        {
            return input.Replace("\"", "").Replace("'", "");
        }
        public Product(string name, string image)
        {
            Name = name;
            //Image = projectDirectory + "\\SP\\"+ RemoveQuotes(image); //cách 1
            Image = projectDirectory+"\\"+RemoveQuotes(image); // cách 2
        }
        public Product(string name, string image, string decription, decimal price = 0)
        {
            Name = name;
            Image = image;
            Description = decription;
            Price = price;
            
        }
    }

    public class Category
    {
        public string Name { get; }
        public string Image { get; }
        public string projectDirectory = GetSiblingDirectory("ImageApp");
        public static string GetSiblingDirectory(string folderName)
        {
            string executingAssemblyPath = Assembly.GetExecutingAssembly().Location;
            string binDirectory = Path.GetDirectoryName(executingAssemblyPath);
            string projectDirectory = Directory.GetParent(binDirectory).FullName;
            string a = Directory.GetParent(projectDirectory).FullName;
            string b = Directory.GetParent(a).FullName;
            string siblingDirectory = Path.Combine(b, folderName);
            return siblingDirectory;
        }

        public string RemoveQuotes(string input)
        {
            return input.Replace("\"", "").Replace("'", "");
        }

        public Category(string name, string image)
        {
            Name = name;
            Image = projectDirectory + "\\" + RemoveQuotes(image);
        }
    }

    public class Brand
    {
        public string Name { get; }
        public string Image { get; }
        public string projectDirectory = GetSiblingDirectory("ImageApp");
        public static string GetSiblingDirectory(string folderName)
        {
            string executingAssemblyPath = Assembly.GetExecutingAssembly().Location;
            string binDirectory = Path.GetDirectoryName(executingAssemblyPath);
            string projectDirectory = Directory.GetParent(binDirectory).FullName;
            string a = Directory.GetParent(projectDirectory).FullName;
            string b = Directory.GetParent(a).FullName;
            string siblingDirectory = Path.Combine(b, folderName);
            return siblingDirectory;
        }

        public string RemoveQuotes(string input)
        {
            return input.Replace("\"", "").Replace("'", "");
        }

        public Brand(string name, string image)
        {
            Name = name;
            Image = projectDirectory + "\\" + RemoveQuotes(image ?? "defaultImage.png");
        }
    }
}
