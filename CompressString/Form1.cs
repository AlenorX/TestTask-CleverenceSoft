using CompressLibrary;

namespace CompressString
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string inputData = textBox.Text;
            string result = "";
            if(CompressFunction.Checked == true)
            {
                result = CompressWork.Compression(inputData);
                label1.Text = $"Результат: {result}";

            }
            else if(DecompressFunction.Checked == true)
            {
                result = CompressWork.Decompression(inputData);
                label1.Text = $"Результат: {result}";
            }


        }

       
    }
}
