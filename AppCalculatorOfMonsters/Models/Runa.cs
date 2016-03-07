using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculatorOfMonsters.Models
{    
    class Runa
    {
        private String tipo;
        private double incremento;
        private int imagen;

        //contenedores
        private static Dictionary<int, Runa> vidaIndividual = new Dictionary<int, Runa>();
        private static Dictionary<int, Runa> vidaEquipo = new Dictionary<int, Runa>();
        private static Dictionary<int, Runa> fuerzaIndividual = new Dictionary<int, Runa>();
        private static Dictionary<int, Runa> fuerzaEquipo = new Dictionary<int, Runa>();
        private static Dictionary<int, Runa> energiaIndividual = new Dictionary<int, Runa>();
        private static Dictionary<int, Runa> energiaEquipo = new Dictionary<int, Runa>();
        private static Dictionary<int, Runa> velocidadIndividual = new Dictionary<int, Runa>();
        private static Dictionary<int, Runa> velocidadEquipo = new Dictionary<int, Runa>();
        private static Dictionary<int, Runa> oroIndividual = new Dictionary<int, Runa>();
        private static Dictionary<int, Runa> oroEquipo = new Dictionary<int, Runa>();

        public Runa(String tipo, double incremento, int imagen)
        {
            this.tipo = tipo;
            this.incremento = incremento;
            this.imagen = imagen;
        }

        public static void cargarRunas()
        {
            velocidadEquipo.Add(1, new Runa("", 1.1, 1));
            velocidadIndividual[new Runa("Vida Monstruo", 1.09, "rutaimagen")] = 1;
            vidaIndividual.put(1, new Runa("Vida Monstruo", 1.09, R.drawable.vida_individual1));
            vidaIndividual.put(2, new Runa("Vida Monstruo", 1.15, R.drawable.vida_individual2));
            vidaIndividual.put(3, new Runa("Vida Monstruo", 1.27, R.drawable.vida_individual3));
            vidaIndividual.put(4, new Runa("Vida Monstruo", 1.39, R.drawable.vida_individual4));
            vidaIndividual.put(5, new Runa("Vida Monstruo", 1.54, R.drawable.vida_individual5));
            vidaIndividual.put(6, new Runa("Vida Monstruo", 1.72, R.drawable.vida_individual6));
            vidaIndividual.put(7, new Runa("Vida Monstruo", 1.84, R.drawable.vida_individual7));
            vidaIndividual.put(8, new Runa("Vida Monstruo", 1.94, R.drawable.vida_individual8));
            vidaIndividual.put(9, new Runa("Vida Monstruo", 1.102, R.drawable.vida_individual9));
            vidaIndividual.put(10, new Runa("Vida Monstruo", 2.08, R.drawable.vida_individual10));

            vidaEquipo = new TreeMap();
            vidaEquipo.put(1, new Runa("Vida Equipo", 1.04, R.drawable.vida_equipo1));
            vidaEquipo.put(2, new Runa("Vida Equipo", 1.07, R.drawable.vida_equipo2));
            vidaEquipo.put(3, new Runa("Vida Equipo", 1.10, R.drawable.vida_equipo3));
            vidaEquipo.put(4, new Runa("Vida Equipo", 1.13, R.drawable.vida_equipo4));
            vidaEquipo.put(5, new Runa("Vida Equipo", 1.16, R.drawable.vida_equipo5));
            vidaEquipo.put(6, new Runa("Vida Equipo", 1.20, R.drawable.vida_equipo6));
            vidaEquipo.put(7, new Runa("Vida Equipo", 1.24, R.drawable.vida_equipo7));
            vidaEquipo.put(8, new Runa("Vida Equipo", 1.27, R.drawable.vida_equipo8));
            vidaEquipo.put(9, new Runa("Vida Equipo", 1.30, R.drawable.vida_equipo9));
            vidaEquipo.put(10, new Runa("Vida Equipo", 1.32, R.drawable.vida_equipo10));

            fuerzaIndividual = new TreeMap();
            fuerzaIndividual.put(1, new Runa("Fuerza Monstruo", 1.06, R.drawable.fuerza_individual1));
            fuerzaIndividual.put(2, new Runa("Fuerza Monstruo", 1.12, R.drawable.fuerza_individual2));
            fuerzaIndividual.put(3, new Runa("Fuerza Monstruo", 1.24, R.drawable.fuerza_individual3));
            fuerzaIndividual.put(4, new Runa("Fuerza Monstruo", 1.36, R.drawable.fuerza_individual4));
            fuerzaIndividual.put(5, new Runa("Fuerza Monstruo", 1.48, R.drawable.fuerza_individual5));
            fuerzaIndividual.put(6, new Runa("Fuerza Monstruo", 1.66, R.drawable.fuerza_individual6));
            fuerzaIndividual.put(7, new Runa("Fuerza Monstruo", 1.78, R.drawable.fuerza_individual7));
            fuerzaIndividual.put(8, new Runa("Fuerza Monstruo", 1.88, R.drawable.fuerza_individual8));
            fuerzaIndividual.put(9, new Runa("Fuerza Monstruo", 1.96, R.drawable.fuerza_individual9));
            fuerzaIndividual.put(10, new Runa("Fuerza Monstruo", 2.02, R.drawable.fuerza_individual10));

            fuerzaEquipo = new TreeMap();
            fuerzaEquipo.put(1, new Runa("Fuerza Equipo", 1.04, R.drawable.fuerza_equipo1));
            fuerzaEquipo.put(2, new Runa("Fuerza Equipo", 1.07, R.drawable.fuerza_equipo2));
            fuerzaEquipo.put(3, new Runa("Fuerza Equipo", 1.10, R.drawable.fuerza_equipo3));
            fuerzaEquipo.put(4, new Runa("Fuerza Equipo", 1.13, R.drawable.fuerza_equipo4));
            fuerzaEquipo.put(5, new Runa("Fuerza Equipo", 1.16, R.drawable.fuerza_equipo5));
            fuerzaEquipo.put(6, new Runa("Fuerza Equipo", 1.19, R.drawable.fuerza_equipo6));
            fuerzaEquipo.put(7, new Runa("Fuerza Equipo", 1.22, R.drawable.fuerza_equipo7));
            fuerzaEquipo.put(8, new Runa("Fuerza Equipo", 1.25, R.drawable.fuerza_equipo8));
            fuerzaEquipo.put(9, new Runa("Fuerza Equipo", 1.27, R.drawable.fuerza_equipo9));
            fuerzaEquipo.put(10, new Runa("Fuerza Equipo", 1.28, R.drawable.fuerza_equipo10));

            energiaIndividual = new TreeMap();
            energiaIndividual.put(1, new Runa("Energía Monstruo", 1.15, R.drawable.energia_individual1));
            energiaIndividual.put(2, new Runa("Energía Monstruo", 1.35, R.drawable.energia_individual2));
            energiaIndividual.put(3, new Runa("Energía Monstruo", 1.50, R.drawable.energia_individual3));
            energiaIndividual.put(4, new Runa("Energía Monstruo", 1.65, R.drawable.energia_individual4));
            energiaIndividual.put(5, new Runa("Energía Monstruo", 1.80, R.drawable.energia_individual5));
            energiaIndividual.put(6, new Runa("Energía Monstruo", 2.0, R.drawable.energia_individual6));
            energiaIndividual.put(7, new Runa("Energía Monstruo", 2.16, R.drawable.energia_individual7));
            energiaIndividual.put(8, new Runa("Energía Monstruo", 2.30, R.drawable.energia_individual8));
            energiaIndividual.put(9, new Runa("Energía Monstruo", 2.42, R.drawable.energia_individual9));
            energiaIndividual.put(10, new Runa("Energía Monstruo", 2.52, R.drawable.energia_individual10));

            energiaEquipo = new TreeMap();
            energiaEquipo.put(1, new Runa("Energía Equipo", 1.04, R.drawable.energia_equipo1));
            energiaEquipo.put(2, new Runa("Energía Equipo", 1.09, R.drawable.energia_equipo2));
            energiaEquipo.put(3, new Runa("Energía Equipo", 1.14, R.drawable.energia_equipo3));
            energiaEquipo.put(4, new Runa("Energía Equipo", 1.19, R.drawable.energia_equipo4));
            energiaEquipo.put(5, new Runa("Energía Equipo", 1.24, R.drawable.energia_equipo5));
            energiaEquipo.put(6, new Runa("Energía Equipo", 1.30, R.drawable.energia_equipo6));
            energiaEquipo.put(7, new Runa("Energía Equipo", 1.36, R.drawable.energia_equipo7));
            energiaEquipo.put(8, new Runa("Energía Equipo", 1.41, R.drawable.energia_equipo8));
            energiaEquipo.put(9, new Runa("Energía Equipo", 1.45, R.drawable.energia_equipo9));
            energiaEquipo.put(10, new Runa("Energía Equipo", 1.48, R.drawable.energia_equipo10));


            velocidadIndividual = new TreeMap();
            velocidadIndividual.put(1, new Runa("Velocidad Monstruo", 1.04, R.drawable.velocidad_individual1));
            velocidadIndividual.put(2, new Runa("Velocidad Monstruo", 1.08, R.drawable.velocidad_individual2));
            velocidadIndividual.put(3, new Runa("Velocidad Monstruo", 1.12, R.drawable.velocidad_individual3));
            velocidadIndividual.put(4, new Runa("Velocidad Monstruo", 1.16, R.drawable.velocidad_individual4));
            velocidadIndividual.put(5, new Runa("Velocidad Monstruo", 1.20, R.drawable.velocidad_individual5));
            velocidadIndividual.put(6, new Runa("Velocidad Monstruo", 1.24, R.drawable.velocidad_individual6));
            velocidadIndividual.put(7, new Runa("Velocidad Monstruo", 1.28, R.drawable.velocidad_individual7));
            velocidadIndividual.put(8, new Runa("Velocidad Monstruo", 1.31, R.drawable.velocidad_individual8));
            velocidadIndividual.put(9, new Runa("Velocidad Monstruo", 1.34, R.drawable.velocidad_individual9));
            velocidadIndividual.put(10, new Runa("Velocidad Monstruo", 1.35, R.drawable.velocidad_individual10));

            velocidadEquipo = new TreeMap();
            velocidadEquipo.put(1, new Runa("Velocidad Equipo", 1.03, R.drawable.velocidad_equipo1));
            velocidadEquipo.put(2, new Runa("Velocidad Equipo", 1.04, R.drawable.velocidad_equipo2));
            velocidadEquipo.put(3, new Runa("Velocidad Equipo", 1.05, R.drawable.velocidad_equipo3));
            velocidadEquipo.put(4, new Runa("Velocidad Equipo", 1.06, R.drawable.velocidad_equipo4));
            velocidadEquipo.put(5, new Runa("Velocidad Equipo", 1.07, R.drawable.velocidad_equipo5));
            velocidadEquipo.put(6, new Runa("Velocidad Equipo", 1.08, R.drawable.velocidad_equipo6));
            velocidadEquipo.put(7, new Runa("Velocidad Equipo", 1.09, R.drawable.velocidad_equipo7));
            velocidadEquipo.put(8, new Runa("Velocidad Equipo", 1.10, R.drawable.velocidad_equipo8));
            velocidadEquipo.put(9, new Runa("Velocidad Equipo", 1.11, R.drawable.velocidad_equipo9));
            velocidadEquipo.put(10, new Runa("Velocidad Equipo", 1.12, R.drawable.velocidad_equipo10));

            oroIndividual = new TreeMap();
            oroIndividual.put(1, new Runa("Oro Monstruo", 1.06, R.drawable.oro_individual1));
            oroIndividual.put(2, new Runa("Oro Monstruo", 1.12, R.drawable.oro_individual2));
            oroIndividual.put(3, new Runa("Oro Monstruo", 1.18, R.drawable.oro_individual3));
            oroIndividual.put(4, new Runa("Oro Monstruo", 1.24, R.drawable.oro_individual4));
            oroIndividual.put(5, new Runa("Oro Monstruo", 1.30, R.drawable.oro_individual5));
            oroIndividual.put(6, new Runa("Oro Monstruo", 1.40, R.drawable.oro_individual6));
            oroIndividual.put(7, new Runa("Oro Monstruo", 1.48, R.drawable.oro_individual7));
            oroIndividual.put(8, new Runa("Oro Monstruo", 1.54, R.drawable.oro_individual8));
            oroIndividual.put(9, new Runa("Oro Monstruo", 1.58, R.drawable.oro_individual9));
            oroIndividual.put(10, new Runa("Oro_Monstruo", 1.60, R.drawable.oro_individual10));

            oroEquipo = new TreeMap();
            oroEquipo.put(1, new Runa("Oro Equipo", 1.02, R.drawable.oro_equipo1));
            oroEquipo.put(2, new Runa("Oro Equipo", 1.04, R.drawable.oro_equipo2));
            oroEquipo.put(3, new Runa("Oro Equipo", 1.06, R.drawable.oro_equipo3));
            oroEquipo.put(4, new Runa("Oro Equipo", 1.08, R.drawable.oro_equipo4));
            oroEquipo.put(5, new Runa("Oro Equipo", 1.10, R.drawable.oro_equipo5));
            oroEquipo.put(6, new Runa("Oro Equipo", 1.14, R.drawable.oro_equipo6));
            oroEquipo.put(7, new Runa("Oro Equipo", 1.18, R.drawable.oro_equipo7));
            oroEquipo.put(8, new Runa("Oro Equipo", 1.21, R.drawable.oro_equipo8));
            oroEquipo.put(9, new Runa("Oro Equipo", 1.23, R.drawable.oro_equipo9));
            oroEquipo.put(10, new Runa("Oro Equipo", 1.24, R.drawable.oro_equipo10));
        }

        public String getTipo()
        {
            return tipo;
        }

        public double getIncremento()
        {
            return incremento;
        }

        public int getImagen()
        {
            return imagen;
        }

        public static Map<Integer, Runa> getVidaIndividual()
        {
            return vidaIndividual;
        }

        public static void setVidaIndividual(Map<Integer, Runa> vidaIndividual)
        {
            Runa.vidaIndividual = vidaIndividual;
        }

        public static Map<Integer, Runa> getVidaEquipo()
        {
            return vidaEquipo;
        }

        public static void setVidaEquipo(Map<Integer, Runa> vidaEquipo)
        {
            Runa.vidaEquipo = vidaEquipo;
        }

        public static Map<Integer, Runa> getFuerzaIndividual()
        {
            return fuerzaIndividual;
        }

        public static void setFuerzaIndividual(Map<Integer, Runa> fuerzaIndividual)
        {
            Runa.fuerzaIndividual = fuerzaIndividual;
        }

        public static Map<Integer, Runa> getFuerzaEquipo()
        {
            return fuerzaEquipo;
        }

        public static void setFuerzaEquipo(Map<Integer, Runa> fuerzaEquipo)
        {
            Runa.fuerzaEquipo = fuerzaEquipo;
        }

        public static Map<Integer, Runa> getEnergiaIndividual()
        {
            return energiaIndividual;
        }

        public static void setEnergiaIndividual(Map<Integer, Runa> energiaIndividual)
        {
            Runa.energiaIndividual = energiaIndividual;
        }

        public static Map<Integer, Runa> getEnergiaEquipo()
        {
            return energiaEquipo;
        }

        public static void setEnergiaEquipo(Map<Integer, Runa> energiaEquipo)
        {
            Runa.energiaEquipo = energiaEquipo;
        }

        public static Map<Integer, Runa> getVelocidadIndividual()
        {
            return velocidadIndividual;
        }

        public static void setVelocidadIndividual(Map<Integer, Runa> velocidadIndividual)
        {
            Runa.velocidadIndividual = velocidadIndividual;
        }

        public static Map<Integer, Runa> getVelocidadEquipo()
        {
            return velocidadEquipo;
        }

        public static void setVelocidadEquipo(Map<Integer, Runa> velocidadEquipo)
        {
            Runa.velocidadEquipo = velocidadEquipo;
        }

        public static Map<Integer, Runa> getOroIndividual()
        {
            return oroIndividual;
        }

        public static void setOroIndividual(Map<Integer, Runa> oroIndividual)
        {
            Runa.oroIndividual = oroIndividual;
        }

        public static Map<Integer, Runa> getOroEquipo()
        {
            return oroEquipo;
        }

        public static void setOroEquipo(Map<Integer, Runa> oroEquipo)
        {
            Runa.oroEquipo = oroEquipo;
        }
    }
}
