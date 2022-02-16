using InterfaceExp02.Models;

namespace InterfaceExp02.Utils
{
    public class Helper : IHelper
    {
        public void filewrite(Textail txt)
        {

            StreamWriter st = new StreamWriter(@"D:\Projects\InterfaceExp02\Static\" + txt.item + ".txt");
            st.WriteLine("Item name :" + txt.item);
            st.WriteLine("Colour of item :" + txt.color);
            st.WriteLine("Number of item :" + txt.number.ToString ());
            st.Close();
        }
    }
}
