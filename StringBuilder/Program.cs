using System.Text;

BuilderString bd = new();
bd.Append("salam");
bd.Append("necesen");
bd.Append("?");
Console.WriteLine(bd.Remove(7, 2).ToString());




StringBuilder st = new StringBuilder();
st.Append("salam");
st.Append("necesen");
st.Append("?");
Console.WriteLine(st.Remove(7, 2).ToString());