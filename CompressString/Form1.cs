using CompressLibrary;

namespace CompressString
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string inputData = textBox.Text;
            string result = "";
            if(CompressFunction.Checked == true)
            {
                result = CompressClass.Compression(inputData);
                label1.Text = $"Результат: {result}";

            }
            else if(DecompressFunction.Checked == true)
            {
                result = CompressClass.Decompression(inputData);
                label1.Text = $"Результат: {result}";
            }
        }
    }
}
