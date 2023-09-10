using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPTabla
{
    class nombre_apellido
    {

        string NomApe;
        public nombre_apellido()
        {

        }
        public string validarNombreApellido(string na)
        {
            NomApe = "";
            int j = 0;
            for (int i = 0; i < (na.Length); i++)
            {
                if (i == 0)
                {
                    if (na[i] != ' ')
                    {
                        NomApe = NomApe + na[i];
                        j++;
                    }
                }
                else
                {
                    if (na[i] != ' ')
                    {
                        NomApe = NomApe + na[i];
                        j++;
                    }
                    else
                    {
                        if (j != 0)
                        {
                            if (NomApe[(j - 1)] != ' ')
                            {
                                NomApe = NomApe + ' ';
                                j++;
                            }
                        }

                    }
                }
            }
            return NomApe;
        }
    }
}
