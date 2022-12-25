namespace StudentForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static String name, lname, city, address, phone = "";

        private void listBox1_Click(object sender, EventArgs e)
        {
            
            switch (listBox1.SelectedItem)
            {
                case "John":
                    {
                        name = "John";
                        lname = "Adam";
                        city = "New York";
                        address = "XYZ road";
                        phone = "021-42892";

                    }
                    break;

                case "Aila":
                    {
                        name = "Aila";
                        lname = "Adil";
                        city = "Karachi";
                        address = "ABC road";
                        phone = "0333-2428932";
                    }
                    break;

                case "Elsa":
                    {
                        name = "Elsa";
                        lname = "yumyum";
                        city = "IStanbul";
                        address = "XYZ road";
                        phone = "04342234";
                    }
                    break;

                case "Anna":
                    {
                        name = "Anna";
                        lname = "Adam";
                        city = "Florida";
                        address = "wxy road";
                        phone = "042244244";
                    }
                    break;

                case "Michael":
                    {
                        name = "Michael";
                        lname = "ninja";
                        city = "Amsterdam";
                        address = "XYZ road";
                        phone = "021-5353332";
                    }
                    break;
                default : MessageBox.Show("Select the item from the list");
                    break;
            }
            textBox1.Text = name;
            textBox2.Text = lname;
            textBox3.Text = city;
            textBox4.Text = address;
            textBox5.Text = phone;
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}