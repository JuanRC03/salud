using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPTabla
{
    class Estado_recomen_ad
    {
        private double talla, peso;
        string Estado;
        string r1;

        public Estado_recomen_ad(double val1, double val2)
        {
            this.talla = val1;
            this.peso = val2;
        }


        public string verificar(double mc)
        {
            if (mc < 23)
            {
                Estado = "Bajo peso";
            }
            if (mc >= 23 && mc < 28)
            {
                Estado = "Normal";
            }
            if (mc >= 28)
            {
                Estado = "Sobrepeso";
            }
            return Estado;
        }


        public string Recomen_Estado_AdulMay()
        {
            if (Estado == "Bajo peso")
            {
                r1 = "- Es conveniente consumir platos completos, de poco volumen, pero muy\nnutritivos (puré con pollo o pescado blanco)\n- Consuma alimentos ricos en nutrientes que incluyan una variedad de frutas y vegetales frescos,\ncereales integrales y carnes sin grasa.\n- Aumente el consumo de leche.\n- Use plantas aromáticas para agregar sabor a las comidas y mejorar el interés en comer.\n- Agregue claras de huevo a las comidas para aumentar las proteínas sin añadir grasas.\n- Reduzca el consumo de sal.\n- Modere el consumo de azúcar.\n- Ingiera bastante agua.";
            }
            if (Estado == "Sobrepeso")
            {
                r1 = "- Debe consumir menos dulces, repostería, bebidas con azúcar.\n- Ingiera cereales (pan, arroz, pasta), papas y legumbres, en cada una de las comidas del día.\n- No abuse de alimentos grasos de origen animal (mayonesa, crema, mantequilla, quesos\ncurados, carnes grasas, embutidos), ya que se relacionan con niveles altos de colesterol y otras\ngrasas que aumentan el riesgo de enfermedades cardiovasculares.\n- Aumente el consumo de leche, de preferencia de bajo\ncontenido graso (descremada o semidescremada).";
            }
            if (Estado == "Normal")
            {
                r1 = "- El índice de masa corporal es adecuado, continúe consumiendo alimentos saludables.\n- Recuerde consumir abundante agua. \n\n\bSugerencias\b\n- 1/2 vaso de jugo de fruta natural\n- Ensalada de zanahoria\n- Ensalada de remolacha con huevo duro\n- Crema de verduras ";
            }
            return r1;
        }
    }
}
