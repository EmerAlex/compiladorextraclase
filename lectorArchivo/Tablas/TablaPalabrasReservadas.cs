using System;
using System.Collections.Generic;
using System.Text;
using lectorArchivo.Transversal;
using System.Linq;

namespace lectorArchivo.Tablas
{
    public class TablaPalabraReservadas
    {
        private Dictionary<String, ComponenteLexico> PALABRAS_RESERVADAS = new Dictionary<string, ComponenteLexico>();
        private Dictionary<String, List<ComponenteLexico>> SIMBOLOS = new Dictionary<string, List<ComponenteLexico>>();
        private static TablaPalabraReservadas INSTANCIA = new TablaPalabraReservadas();

        private TablaPalabraReservadas()
        {
            PALABRAS_RESERVADAS.Add("A", ComponenteLexico.CrearComponentePalabraReservada("A", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("B", ComponenteLexico.CrearComponentePalabraReservada("B", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("C", ComponenteLexico.CrearComponentePalabraReservada("C", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("D", ComponenteLexico.CrearComponentePalabraReservada("D", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("E", ComponenteLexico.CrearComponentePalabraReservada("E", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("F", ComponenteLexico.CrearComponentePalabraReservada("F", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("G", ComponenteLexico.CrearComponentePalabraReservada("G", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("H", ComponenteLexico.CrearComponentePalabraReservada("H", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("I", ComponenteLexico.CrearComponentePalabraReservada("I", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("J", ComponenteLexico.CrearComponentePalabraReservada("J", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("K", ComponenteLexico.CrearComponentePalabraReservada("K", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("L", ComponenteLexico.CrearComponentePalabraReservada("L", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("M", ComponenteLexico.CrearComponentePalabraReservada("M", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("N", ComponenteLexico.CrearComponentePalabraReservada("N", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("Ñ", ComponenteLexico.CrearComponentePalabraReservada("Ñ", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("O", ComponenteLexico.CrearComponentePalabraReservada("O", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("P", ComponenteLexico.CrearComponentePalabraReservada("P", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("Q", ComponenteLexico.CrearComponentePalabraReservada("Q", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("R", ComponenteLexico.CrearComponentePalabraReservada("R", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("S", ComponenteLexico.CrearComponentePalabraReservada("S", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("T", ComponenteLexico.CrearComponentePalabraReservada("T", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("U", ComponenteLexico.CrearComponentePalabraReservada("U", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("V", ComponenteLexico.CrearComponentePalabraReservada("V", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("W", ComponenteLexico.CrearComponentePalabraReservada("W", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("X", ComponenteLexico.CrearComponentePalabraReservada("X", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("Y", ComponenteLexico.CrearComponentePalabraReservada("Y", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("Z", ComponenteLexico.CrearComponentePalabraReservada("Z", Categoria.LETRA_MORSE));
            PALABRAS_RESERVADAS.Add("Á", ComponenteLexico.CrearComponentePalabraReservada("Á", Categoria.TILDE_A_MORSE));
            PALABRAS_RESERVADAS.Add("É", ComponenteLexico.CrearComponentePalabraReservada("É", Categoria.TILDE_E_MORSE));
            PALABRAS_RESERVADAS.Add("Ó", ComponenteLexico.CrearComponentePalabraReservada("Ó", Categoria.TILDE_O_MORSE));
            PALABRAS_RESERVADAS.Add("1", ComponenteLexico.CrearComponentePalabraReservada("1", Categoria.NUMERO_MORSE));
            PALABRAS_RESERVADAS.Add("2", ComponenteLexico.CrearComponentePalabraReservada("2", Categoria.NUMERO_MORSE));
            PALABRAS_RESERVADAS.Add("3", ComponenteLexico.CrearComponentePalabraReservada("3", Categoria.NUMERO_MORSE));
            PALABRAS_RESERVADAS.Add("4", ComponenteLexico.CrearComponentePalabraReservada("4", Categoria.NUMERO_MORSE));
            PALABRAS_RESERVADAS.Add("5", ComponenteLexico.CrearComponentePalabraReservada("5", Categoria.NUMERO_MORSE));
            PALABRAS_RESERVADAS.Add("6", ComponenteLexico.CrearComponentePalabraReservada("6", Categoria.NUMERO_MORSE));
            PALABRAS_RESERVADAS.Add("7", ComponenteLexico.CrearComponentePalabraReservada("7", Categoria.NUMERO_MORSE));
            PALABRAS_RESERVADAS.Add("8", ComponenteLexico.CrearComponentePalabraReservada("8", Categoria.NUMERO_MORSE));
            PALABRAS_RESERVADAS.Add("9", ComponenteLexico.CrearComponentePalabraReservada("9", Categoria.NUMERO_MORSE));
            PALABRAS_RESERVADAS.Add("0", ComponenteLexico.CrearComponentePalabraReservada("0", Categoria.NUMERO_MORSE));
            PALABRAS_RESERVADAS.Add("\"", ComponenteLexico.CrearComponentePalabraReservada("\"", Categoria.COMILLAS_DOBLES_MORSE));
            PALABRAS_RESERVADAS.Add(".", ComponenteLexico.CrearComponentePalabraReservada(".", Categoria.PUNTO_MORSE));
            PALABRAS_RESERVADAS.Add(",", ComponenteLexico.CrearComponentePalabraReservada(",", Categoria.COMA_MORSE));
            PALABRAS_RESERVADAS.Add("?", ComponenteLexico.CrearComponentePalabraReservada("?", Categoria.PREGUNTA_CIERRA_MORSE));
            PALABRAS_RESERVADAS.Add("¿", ComponenteLexico.CrearComponentePalabraReservada("¿", Categoria.PREGUNTA_ABRE_MORSE));
            PALABRAS_RESERVADAS.Add("'", ComponenteLexico.CrearComponentePalabraReservada("'", Categoria.COMILLA_SIMPLE_MORSE));
            PALABRAS_RESERVADAS.Add("!", ComponenteLexico.CrearComponentePalabraReservada("!", Categoria.ADMIRACION_CIERRA_MORSE));
            PALABRAS_RESERVADAS.Add("¡", ComponenteLexico.CrearComponentePalabraReservada("¡", Categoria.ADMIRACION_ABRE_MORSE));
            PALABRAS_RESERVADAS.Add("/", ComponenteLexico.CrearComponentePalabraReservada("/", Categoria.BARRA_INCLINADA_MORSE));
            PALABRAS_RESERVADAS.Add("(", ComponenteLexico.CrearComponentePalabraReservada("(", Categoria.PARENTESIS_ABRE_MORSE));
            PALABRAS_RESERVADAS.Add(")", ComponenteLexico.CrearComponentePalabraReservada(")", Categoria.PARENTESIS_CIERRA_MORSE));
            PALABRAS_RESERVADAS.Add("&", ComponenteLexico.CrearComponentePalabraReservada("&", Categoria.ET_MORSE));
            PALABRAS_RESERVADAS.Add(":", ComponenteLexico.CrearComponentePalabraReservada(":", Categoria.DOS_PUNTOS_MORSE));
            PALABRAS_RESERVADAS.Add(";", ComponenteLexico.CrearComponentePalabraReservada(";", Categoria.PUNTO_Y_COMA_MORSE));
            PALABRAS_RESERVADAS.Add("=", ComponenteLexico.CrearComponentePalabraReservada("=", Categoria.IGUAL_MORSE));
            PALABRAS_RESERVADAS.Add("+", ComponenteLexico.CrearComponentePalabraReservada("+", Categoria.MAS_MORSE));
            PALABRAS_RESERVADAS.Add("-", ComponenteLexico.CrearComponentePalabraReservada("-", Categoria.GUION_MORSE));
            PALABRAS_RESERVADAS.Add("_", ComponenteLexico.CrearComponentePalabraReservada("_", Categoria.GUION_BAJO_MORSE));
            PALABRAS_RESERVADAS.Add("$", ComponenteLexico.CrearComponentePalabraReservada("$", Categoria.SIGNO_PESOS_MORSE));
            PALABRAS_RESERVADAS.Add("@", ComponenteLexico.CrearComponentePalabraReservada("@", Categoria.ARROBA_MORSE));
            PALABRAS_RESERVADAS.Add(" ", ComponenteLexico.CrearComponentePalabraReservada(" ", Categoria.ESPACIO_MORSE));
        }



        public static void Limpiar()
        {
            INSTANCIA.SIMBOLOS.Clear();
        }
        private List<ComponenteLexico> ObetenerSimbolo(String Lexema)
        {
            if (!SIMBOLOS.ContainsKey(Lexema))
            {
                SIMBOLOS.Add(Lexema, new List<ComponenteLexico>());

            }
            return SIMBOLOS[Lexema];
        }
        public static void Agregar(ComponenteLexico componente)
        {
            if (componente != null
                && !componente.ObtenerLexema().Equals("")
                && componente.ObtenerTipo().Equals(TipoComponente.PALABRA_RESERVADA))
            {
                INSTANCIA.ObetenerSimbolo(componente.ObtenerLexema()).Add(componente);
            }
        }
        public static List<ComponenteLexico> ObtenerSimbolos()
        {
            return INSTANCIA.SIMBOLOS.Values.SelectMany(componente => componente).ToList();
        }
       

        public Boolean EsPalabraReservada(String Lexema)
        {
            return PALABRAS_RESERVADAS.ContainsKey(Lexema.ToUpper());

        }
        public ComponenteLexico ObtenerPalabraReservada(String Lexema)
        {
            return PALABRAS_RESERVADAS[Lexema.ToUpper()];
        }

        public static ComponenteLexico ComprobarPalabraReservada(ComponenteLexico Componente)
        {
            if (Componente != null && INSTANCIA.EsPalabraReservada(Componente.ObtenerLexema()))
            {
                
                Categoria Categoria = INSTANCIA.ObtenerPalabraReservada(Componente.ObtenerLexema()).ObtenerCategoria();
                ComponenteLexico NuevoComponente = ComponenteLexico.CrearComponenteSimbolo(Componente.ObtenerLexema(), Categoria, Componente.ObtenerNumeroLinea(), Componente.ObetenerPosicionInicial(), Componente.ObtenerPosicionFinal());

                return NuevoComponente;
            }

            return Componente;
        }
    }
}
