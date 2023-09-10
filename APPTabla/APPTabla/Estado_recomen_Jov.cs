using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPTabla
{
    class Estado_recomen_Jov
    {
        double talla;
        //int edad;
        double peso;

        public Estado_recomen_Jov(double t, double pe)
        {
            talla = t;
            peso = pe;



        }
        string Estado;
        string r1;
        public string verificar()
        {
            //if(edad>11 && edad < 13)//12
            //{
            if (talla >= 1.46 && talla < 1.56)
            {

                if (peso >= 46.67)
                {
                    Estado = "Sobrepeso";
                }
                else
                {
                    if (peso <= 36.51)
                    {
                        Estado = "Bajo peso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            // }

            //if (edad > 12 && edad < 14)//13
            //{
            if (talla >= 1.56 && talla < 1.60)
            {

                if (peso >= 52.15)
                {
                    Estado = "Sobrepeso";
                }
                else
                {
                    if (peso <= 46.68)
                    {
                        Estado = "Bajo peso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }

            }
            // Estado = "Pequeño ";
            //  }
            //if (edad > 13 && edad < 15)//14
            //{
            if (talla >= 1.60 && talla < 1.68)
            {

                if (peso >= 57.49)
                {
                    Estado = "Sobrepeso";
                }
                else
                {
                    if (peso <= 52.15)
                    {
                        Estado = "Bajo peso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            //  }
            //if (edad > 14 && edad < 16)//15
            //{
            if (talla >= 1.68 && talla < 1.71)
            {

                if (peso >= 62.27)
                {
                    Estado = "Sobrepeso";
                }
                else
                {
                    if (peso <= 57.49)
                    {
                        Estado = "Bajo peso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            // }
            //if (edad > 15 && edad < 17)//16
            //{
            if (talla >= 1.71 && talla < 1.73)
            {

                if (peso >= 66.03)
                {
                    Estado = "Sobrepeso";
                }
                else
                {
                    if (peso <= 62.27)
                    {
                        Estado = "Bajo peso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            //}
            //if (edad > 16 && edad < 18)//17
            //{
            if (talla >= 1.73 && talla < 1.74)
            {

                if (peso >= 68.19)
                {
                    Estado = "Sobrepeso";
                }
                else
                {
                    if (peso <= 66.03)
                    {
                        Estado = "Bajo peso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            // }
            //if (edad > 17 && edad < 19)//18
            //{
            if (talla >= 1.75 && talla < 1.78)
            {

                if (peso >= 71.02)
                {
                    Estado = "Sobrepeso";
                }
                else
                {
                    if (peso <= 68.19)
                    {
                        Estado = "Bajo peso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            // }
            //if (edad > 18 && edad < 20)//19
            //{
            if (talla >= 1.78 && talla < 1.82)
            {

                if (peso >= 82.03)
                {
                    Estado = "Sobrepeso";
                }
                else
                {
                    if (peso <= 71.02)
                    {
                        Estado = "Bajo peso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            
            //}
            return Estado;
        }
        public string Recomendacion_estado()
        {
            if (Estado == "Bajo peso")
            {
                r1 = "Tomar batidos y licuado de frutas altas en calorías\nComer de 5 a 6 veces al día\nAumentar el consumo de carbohidratos como cereales, pan, arroz, pasta, legumbres\nAumentar el consumo de proteínas como carnes magras, pollo, pescado, lácteos, huevos.\nConsumir alimentos altos en grasas saludables como frutos secos y pescado\nConsumir de 2 a 3 litros de agua al día\nConsumir frutas y verduras en grandes cantidades\nHacer 60 minutos de actividad física cada día";
            }
            if (Estado == "Sobrepeso")
            {
                r1 = "Limitar el consumo de alimentos que sean ricos en azúcares y grasas\nComer varias veces al día frutas y verduras, así como legumbres, cereales integrales y frutos secos.\nConsumir de 2 a 3 litros de agua al día.\nHacer ejercicio por lo menos 30 minutos al día.\nConsumir proteínas como carnes magras, pollo sin la piel, pescados, huevos, leches desnatadas,\nquesos frescos de preferencia integrales.\nConsumir verduras y frutas en todas sus comidas.\n";
            }
            if (Estado == "Normal")
            {
                r1 = "Mantener el mismo consumo de calorías diarias.\nEvitar el excesivo consumo de bebidas azucaradas.\nRealizar 30 minutos de ejercicio diario";
            }
            return r1;
        }
    }

}
