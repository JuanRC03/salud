using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfNinios
{
    public class Estado_recomen_n
    {
        int edad;
        double peso;
        public Estado_recomen_n(int edad, double peso)
        {
            this.edad = edad;
            this.peso = peso;

        }
        string Estado;
        string r1;
        public string verificar()
        {
            if (edad == 0)
            {
                if (peso > 4.5)
                {
                    Estado = "Sobrepeso";
                }
                else
                {
                    if (peso < 2.5)
                    {
                        Estado = "Bajo peso";
                    }
                    else 
                    {
                        Estado = "Normal";
                    }
                }
            }
            if (edad >=1  && edad <=2)
            {
                if (peso >15.5 )
                {
                    Estado = "Sobrepeso";
                }
                else
                {
                    if (peso < 6.5)
                    {
                        Estado = "Bajo peso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            if (edad >=3 && edad <=5)
            {
                if (peso < 9.65)
                {
                    Estado = "Bajo peso";
                }
                else
                {
                    if (peso > 22.65)
                    {
                        Estado = "Sobrepeso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            if (edad >= 6 && edad <=8)
            {
                if (peso < 10.15)
                {
                    Estado = "Bajo peso";
                }
                else
                {
                    if (peso > 31.15)
                    {
                        Estado = "Sobrepeso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            if (edad >=9 && edad <= 10)
            {
                if (peso <= 16.16)
                {
                    Estado = "Bajo peso";
                }
                else
                {
                    if (peso >= 36.17)
                    {
                        Estado = "Sobrepeso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            if (edad == 11)
            {
                if (peso < 25.81)
                {
                    Estado = "Bajo peso";
                }
                else
                {
                    if (peso > 45.81)
                    {
                        Estado = "Sobrepeso";
                    }
                    else
                    {
                        Estado = "Normal";
                    }
                }
            }
            
            return Estado;
        }
        public string Recomendacion_estado()
        {
            if (edad == 0)
            {
                if (Estado == "Bajo peso")
                {
                    r1 = "Amamartar solo de leche materna  entre 12 - 15 veces al día\nEmplear el uso de biberón con suplemento vitamínico (3veces/días)\nAcudir al doctor para recibir una adecuada indicación alimenticia";
                }
                if (Estado == "Sobrepeso")
                {
                    r1 = "Amamartar solo de leche materna  entre 8 - 12 veces al día\nEvitar el uso de biberón con suplementos";
                }
                if (Estado == "Normal")
                {
                    r1 = "Mantener el mismo consumo de leche materna.";
                }

            }
            else if(edad>=1 && edad<=2)
            {
                if (Estado == "Bajo peso")
                {
                    r1 = "Consumir leche materina si es el caso.\n1/4 de jugo de taza de fruta o verdura y 1/2 porción de pan o grano.\nSuplementos:Carne o pollo o pescado (Aumentar el consumo de 1/2 onza a 1 onza)\nProductos proteicos alternativos, queso, o huevo, o frijoles o guisantes secos cocidos,\n o manteca de mani u otras mantecas de nueces o semillas, o Nueces o semillas,\n o Yogurt – natural o endulzado /saborizado\nElegir dos componentes a elección (1/2 onza)\nAgregar el consumo de alimentos entre comidas.\nConsumo de suplementos alimenticios en biberón.\nAumentar el consumo de papillas nutritivas.";
                }
                if (Estado == "Sobrepeso")
                {
                    r1 = "Consumir leche materina si es el caso.\n1/4 de jugo de taza de fruta o verdura y 1/2 porción de pan o grano.\nSuplementos:Carne o pollo o pescado\nProductos proteicos alternativos, queso, o huevo, o frijoles o guisantes secos cocidos.\nElegir dos componentes a elección (1/2 onza).\nComida cocinada al vapor y evitar fritos.";
                }
                if (Estado == "Normal")
                {
                    r1 = "Consumir leche materina si es el caso.\n1/4 de jugo de taza defruta o verdura y 1/2 porción de pan o grano.\nSuplementos:Carne o pollo o pescado\nProductos proteicos alternativos, queso, o huevo, o frijoles o guisantes secos cocidos,\n o manteca de mani u otras mantecas de nueces o semillas, o Nueces o semillas,\n o Yogurt – natural o endulzado /saborizado\nElegir dos componentes a elección (1/2 onza)";
                }

            }
            else
            {
                if (Estado == "Bajo peso")
                {
                    r1 = "Consumir 1 taza de jugo de fruta o verdura y 1 porción de pan o grano.\nSuplementos:Carne o pollo o pescado (Aumentar el consumo de 1/2 onza a 1 onza)\nProductos proteicos alternativos, queso, o huevo, o frijoles o guisantes secos cocidos,\n o manteca de mani u otras mantecas de nueces o semillas, o Nueces o semillas,\n o Yogurt – natural o endulzado /saborizado\nElegir dos componentes a elección (2 onzas).\nAgregar el consumo de alimentos entre comidas.\nConsumo de suplementos alimenticios y vitamínicos.";
                }
                if (Estado == "Sobrepeso")
                {
                    r1 = "Consumir 1 taza de jugo de fruta o verdura y 1 porción de pan o grano.\nSuplementos:Carne o pollo o pescado (Aumentar el consumo de 1/2 onza a 1 onza)\nProductos proteicos alternativos, queso, o huevo, o frijoles o guisantes secos cocidos\nElegir dos componentes a elección (2 onzas),\nAgregar el consumo de alimentos entre comidas.\nEvitar el consumode grasas saturadas.\nAumentar la actividad física.\nComidas cocinadas al vapor o al horno (evitar fritos)\nDisminuir el consumo de lacteos suerior al 85% de grasas.\nAumentar el consumo de frutas y verduras";
                }
                if (Estado == "Normal")
                {
                    r1 = "Consumir 1 taza jugo de fruta o verdura y 1 porción de pan o grano.\nSuplementos:Carne o pollo o pescado (Aumentar el consumo de 1/2 onza a 1 onza)\nProductos proteicos alternativos, queso, o huevo, o frijoles o guisantes secos cocidos,\n o manteca de mani u otras mantecas de nueces o semillas, o Nueces o semillas,\n o Yogurt – natural o endulzado /saborizado\nElegir dos componentes a elección (2 onza)\nAgregar el consumo de alimentos entre comidas.";
                }

            }
            
            return r1;
        }
    }
}
