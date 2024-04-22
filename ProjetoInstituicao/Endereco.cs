using System.Text;

namespace Primeiroprojeto
{
    public class Endereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }                
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine(Rua + " " + Numero + " " + Bairro);
            return sb.ToString();
        }

    }
}
