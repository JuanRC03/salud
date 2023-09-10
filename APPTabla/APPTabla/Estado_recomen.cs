using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPTabla
{
    class Estado_recomen
    {
        double talla;
        double mc;
        public Estado_recomen(double t, double m)
        {
            talla = t;
            mc = m;

        }
        string Estado;
        string r1;
        public string verificar()
        {
            if (talla >= 1.50 && talla < 1.55)
            {
                if (mc >= 24.4)
                {
                    Estado = "Sobrepeso";
                }
                else
                {
                    if (mc <= 17.74)
                    {
                        Estado = "Bajo peso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            if (talla >= 1.55 && talla < 1.60)
            {
                if (mc >= 25)
                {
                    Estado = "Sobrepeso";
                }
                else
                {
                    if (mc <= 16.6)
                    {
                        Estado = "Bajo peso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            if (talla >= 1.60 && talla < 1.65)
            {
                if (mc <= 17.6)
                {
                    Estado = "Bajo peso";
                }
                else
                {
                    if (mc >= 25.4)
                    {
                        Estado = "Sobrepeso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            if (talla >= 1.65 && talla < 1.70)
            {
                if (mc <= 18.4)
                {
                    Estado = "Bajo peso";
                }
                else
                {
                    if (mc >= 25.7)
                    {
                        Estado = "Sobrepeso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            if (talla >= 1.70 && talla < 1.75)
            {
                if (mc <= 17.3)
                {
                    Estado = "Bajo peso";
                }
                else
                {
                    if (mc >= 26)
                    {
                        Estado = "Sobrepeso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            if (talla >= 1.75 && talla < 1.80)
            {
                if (mc <= 18)
                {
                    Estado = "Bajo peso";
                }
                else
                {
                    if (mc >= 26.1)
                    {
                        Estado = "Sobrepeso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            if (talla >= 1.80 && talla < 1.85)
            {
                if (mc <= 17)
                {
                    Estado = "Bajo peso";
                }
                else
                {
                    if (mc >= 26.2)
                    {
                        Estado = "Sobrepeso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            if (talla >= 1.85 && talla < 1.90)
            {
                if (mc <= 17.5)
                {
                    Estado = "Bajo peso";
                }
                else
                {
                    if (mc >= 26.2)
                    {
                        Estado = "Sobrepeso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            if (talla >= 1.90 && talla < 1.95)
            {
                if (mc <= 18)
                {
                    Estado = "Bajo peso";
                }
                else
                {
                    if (mc >= 26.3)
                    {
                        Estado = "Sobrepeso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            if (talla >= 1.95 && talla < 2)
            {
                if (mc <= 18.4)
                {
                    Estado = "Bajo peso";
                }
                else
                {
                    if (mc >= 25)
                    {
                        Estado = "Sobrepeso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            if (talla >= 2 && talla < 2.05)
            {
                if (mc <= 17.5)
                {
                    Estado = "Bajo peso";
                }
                else
                {
                    if (mc >= 25)
                    {
                        Estado = "Sobrepeso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            if (talla >= 2.05 && talla < 2.10)
            {
                if (mc <= 17.8)
                {
                    Estado = "Bajo peso";
                }
                else
                {
                    if (mc >= 25)
                    {
                        Estado = "Sobrepeso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            else
            {
                if (mc < 18.5)
                {
                    Estado = "Bajo peso";
                }
                if (mc >= 18.5 && mc < 24.9)
                {
                    Estado = "Normal";
                }
                if (mc >= 25)
                {
                    Estado = "Sobrepeso";
                }
            }
            return Estado;
        }
        public string Recomendacion_estado() 
        { 
            if (Estado == "Bajo peso")
            {
                r1 = "Comer de 5 a 6 veces al día\nAumentar el consumo de carbohidratos como cereales, pan, arroz, pasta, legumbres\nAumentar el consumo de proteínas de alto valor biológico carnes magras, pollo, pescado, lácteos, huevos.\nConsumir de 2 a 3 litros de agua al día\nConsumir frutas y verduras en grandes cantidades";
            }
            if (Estado == "Sobrepeso")
            {
                r1 = "Comer de 3 a 6 veces al día\nDisminuir el consumo de azúcar y sal.\nConsumir de 2 a 3 litros de agua al día.\nHacer ejercicio por lo menos 30 minutos al día.\nConsumir proteínas como carnes magras, pollo sin la piel, pescados, huevos,leches desnatadas,\nquesos frescos.\nNo consumir alimentos chatarra, consumir carbohidratos complejos como arroz, pan, pasta,\nde preferencia integrales.\nConsumir verduras y frutas en todas sus comidas.\nY preparar los alimentos al vapor o al horno";
            }
            if (Estado == "Normal")
            {
                r1 = "Mantener el mismo consumo de calorías diarias.\nEvitar el exesivo consumo de bebidas azucaradas.\nRealizar 30 minutos de ejercicio diario";
            }
            return r1;
        }
    }
}
