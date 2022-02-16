using InterfaceExp02.Models;

namespace InterfaceExp02.Utils
{
    public class Helper : IHelper
    {
        public void filewrite(Textail newtextail)
        {

            StreamWriter st = new StreamWriter(@"D:\Projects\InterfaceExp02\Static\" + newtextail.item + ".txt");
            st.WriteLine("Item name :" + newtextail.item);
            st.WriteLine("Colour of item :" + newtextail.color);
            st.WriteLine("Number of item :" + newtextail.number.ToString ());
            st.Close();
        }
    }
}
