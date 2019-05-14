using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase_14
{
    public static class ParseadoraDeEnteros
    {
        public static bool TryParse(string s, out int e)
        {
            bool flag = true;
            e = 0;
            try
            {                
                e = int.Parse(s);
            }
            catch (Exception)
            {
                flag = false;
            }
            
            return flag;
        }

        public static int Parse(string s)
        {
            int retorno = 0;
            try
            {                    
                retorno = int.Parse(s);
            }
            catch (FormatException f)
            {               
                throw new ErrorParserException(" El string no podrá ser convertido.", f);                
            }
            catch (OverflowException o)
            {
                throw new ErrorParserException("El string no podrá ser convertido.", o);                
            }
            
            return retorno;
        }
    }
}
