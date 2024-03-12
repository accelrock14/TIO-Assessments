using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Assessment07_03_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class IDE
    {
        JavaLang java = new JavaLang();
        CSharpLang csharp = new CSharpLang();
        CLang cLang = new CLang();
    }

    public interface IProgramingLanguage
    {

    }
    public class OOLanguage : IProgramingLanguage
    {
        public IProgramingLanguage IProgramingLanguage
        {
            get => default;
            set
            {
            }
        }
    }
    public class ProceduralLanguage : IProgramingLanguage
    {
        public IProgramingLanguage IProgramingLanguage
        {
            get => default;
            set
            {
            }
        }
    }
    public class JavaLang : OOLanguage
    {

    }
    public class CSharpLang : OOLanguage
    {

    }
    public class CLang : ProceduralLanguage
    {

    }
}
