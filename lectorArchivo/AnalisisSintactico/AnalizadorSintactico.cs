using System;
using System.Collections.Generic;
using System.Text;
using lectorArchivo.Analizador;
using lectorArchivo.Transversal;
using System.Windows.Forms;
using lectorArchivo.GestorErrores;

namespace lectorArchivo.AnalisisSintactico
{
    public class AnalizadorSintactico
    {
        private ComponenteLexico Componente;
        private AnalizadorLexico AnaLex;
        private StringBuilder TrazaDerivacion;
        private StringBuilder Resultado;
        private bool Metodo;


        private bool SaltoLinea;

        public Dictionary<string, object> Analizar(bool depurar, bool Metodo)
        {
            AnaLex = new AnalizadorLexico();
            this.Metodo = Metodo;
            TrazaDerivacion = new StringBuilder();
            Resultado = new StringBuilder();
            SaltoLinea = true;
            
            if (this.Metodo)
            {
                
                Avanzar();
                Morse(0);
                if (depurar)
                {
                    MessageBox.Show(TrazaDerivacion.ToString());
                }
            }
            else
            {
                Avanzar();
                Latin(0);
                if (depurar)
                {
                    MessageBox.Show(TrazaDerivacion.ToString());
                }
            }

            Dictionary<string, object> Respuesta = new Dictionary<string, object>();
            Respuesta.Add("COMPONENTE", Componente);
            Respuesta.Add("RESULTADO", Resultado);
            return Respuesta;

        }

        
        //<morse>:: <simboloMorse><morseSec> 
        private void Morse(int jerarquia)
        {
            TrazarEntrada("<Morse>", jerarquia);
            SimboloMorse(jerarquia+1);
            MorseSec(jerarquia + 1);
            TrazarSalida("</Morse>", jerarquia);
        }
       
        //<morseSec> :: <morse>|epsilon {., ,-} 
        private void MorseSec(int jerarquia)
        {
            TrazarEntrada("<MorseSec>", jerarquia);
            if (!Categoria.FIN_DE_ARCHIVO.Equals(Componente.ObtenerCategoria()))
            {
                Morse(jerarquia + 1);
            }
            TrazarSalida("</MorseSEc>", jerarquia);
        }
        //<simboloMorse>:: .| |-  {., ,-}
        private void SimboloMorse(int jerarquia)
        {
            TrazarEntrada("<SimboloMorse>", jerarquia);
            if (Categoria.LETRA_A.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_B.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_C.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_D.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_E.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_F.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_G.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_H.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_I.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_J.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_K.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_L.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_M.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_N.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_O.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_P.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_Q.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_R.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_S.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_T.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_U.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_V.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_W.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_X.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_Y.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_Z.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_TILDE_A.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_TILDE_E.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_TILDE_O.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.NUMERO_CERO.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.NUMERO_UNO.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.NUMERO_DOS.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.NUMERO_TRES.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.NUMERO_CUATRO.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.NUMERO_CINCO.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.NUMERO_SEIS.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.NUMERO_SIETE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.NUMERO_OCHO.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.NUMERO_NUEVE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.NUMERO_CERO.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_ET.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_ENYE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.PUNTO.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.COMA.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.INTERROGACION_ABRE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.INTERROGACION_CIERRA.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.DOS_PUNTOS.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.COMILLA_SIMPLE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.ADMIRACION_ABRE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.ADMIRACION_CIERRA.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.PARENTESIS_ABRE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.PARENTESIS_CIERRA.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.PUNTO_Y_COMA.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.IGUAL.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.MAS.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.GUION.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.GUION_BAJO.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.COMILLAS_DOBLES.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.BARRA_INCLINADA.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.ESPACIO.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.SIGNO_PESOS.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }
            else if (Categoria.ARROBA.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoMorse(Componente);
                Avanzar();
            }

            else
            {
                String Causa = "Caracter leido no valido " + Componente.ObtenerCategoria();
                String falla = "Caracter no valido";
                String Solucion = "Asegurese que el morse esta biene escrito";

                Error Error = Error.CrearErrorSintactico(Componente.ObtenerLexema(), Componente.ObtenerCategoria(), Componente.ObtenerNumeroLinea(), Componente.ObetenerPosicionInicial(), Componente.ObtenerPosicionFinal(), falla, Causa, Solucion);
                ManejadorErrores.Reportar(Error);
                throw new Exception("Se ha presentado un error de tipo stopper dentro del proceso de compilacion. Por favor revise la consola de errores... [Analizador Sintactico]");
            }
            TrazarSalida("</SimboloMorse>", jerarquia);


        }

        //<latin>:: <alfabeto><latinSec>
        private void Latin(int jerarquia)
        {
            TrazarEntrada("<Latin>", jerarquia);
            Alfabeto(jerarquia+1);
            LatinSec(jerarquia+1);
            TrazarSalida("</Latin>", jerarquia);
        }
        //<latinSec>:: <latin>|epsilon
        private void LatinSec(int jerarquia)
        {
            TrazarEntrada("<LatinSec>", jerarquia);
            if (!Categoria.FIN_DE_ARCHIVO.Equals(Componente.ObtenerCategoria()))
            {
                Latin(jerarquia + 1);
            }
            TrazarSalida("</LatinSec>", jerarquia);
        }
        //<alfabeto>:: a|b|c|d|e|f|g|h|i|j|k|l|m|n|o|p|q|r|s|t|u|v|w|x|y|z|ñ|á|é|ó|A|B|C|D|E|F|G|H|I|J|K|L|M|N|O|P|Q|R|S|T|U|V|W|X|Y|Z|Ñ|Ó|Á|É|<numero>
        private void Alfabeto(int jerarquia)
        {
            TrazarEntrada("<Alfabeto>", jerarquia);
            if (Categoria.LETRA_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.TILDE_O_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.TILDE_A_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.TILDE_E_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.LETRA_ENYE_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else {
                Numero(0);
            }
            TrazarSalida("</Alfabet>", jerarquia);
        }
        //<numero>:: 1|2|3|4|5|6|7|8|9|0|<simboloLatin>
        private void Numero(int jerarquia)
        {
            TrazarEntrada("<Numero>", jerarquia);
            if (Categoria.NUMERO_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else
            {
                SimboloLatin(jerarquia + 1);
            }
            TrazarSalida("</Numero>", jerarquia);
        }
        //<simboloLatin>::!|¡|¿|?|'|¨|_|-|(|)|/|&|:|;| |=|+|$|@|.|,
        private void SimboloLatin(int jerarquia)
        {
            TrazarEntrada("<SimboloLatin>", jerarquia);
            if (Categoria.ET_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.PREGUNTA_ABRE_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.PREGUNTA_CIERRA_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.COMILLA_SIMPLE_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.ADMIRACION_ABRE_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.ADMIRACION_CIERRA_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.BARRA_INCLINADA_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.PARENTESIS_ABRE_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.PARENTESIS_CIERRA_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.DOS_PUNTOS_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.PUNTO_Y_COMA_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.IGUAL_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.MAS_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.GUION_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            
            else if (Categoria.COMILLAS_DOBLES_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.SIGNO_PESOS_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.ARROBA_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.ESPACIO_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.PUNTO_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.COMA_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.GUION_BAJO_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else if (Categoria.FIN_DE_LINEA.Equals(Componente.ObtenerCategoria()))
            {
                FormarResultadoLatin(Componente);
                Avanzar();
            }
            else
            {
                String Causa = "Caracter leido no valido " + Componente.ObtenerCategoria();
                String falla = "Caracter no valido";
                String Solucion = "Asegurese que el morse esta biene escrito";

                Error Error = Error.CrearErrorSintactico(Componente.ObtenerLexema(), Componente.ObtenerCategoria(), Componente.ObtenerNumeroLinea(), Componente.ObetenerPosicionInicial(), Componente.ObtenerPosicionFinal(), falla, Causa, Solucion);
                ManejadorErrores.Reportar(Error);
                throw new Exception("Se ha presentado un error de tipo stopper dentro del proceso de compilacion. Por favor revise la consola de errores...");
            }
            TrazarSalida("</SimboloLatin>", jerarquia);
        }
            
       
        private void Avanzar()
        {
            Componente = AnaLex.Analizador(this.Metodo);
        }
        private void TrazarEntrada(string NombreRegla, int jerarquia)
        {
            TrazaDerivacion.Append(FormarCadenaEspaciosBlanco(jerarquia));
            TrazaDerivacion.Append(NombreRegla).Append("(").Append(Componente.ObtenerCategoria()).Append(")");
            TrazaDerivacion.Append(Environment.NewLine);

        }
        private void TrazarSalida(string NombreRegla, int jerarquia)
        {
            TrazaDerivacion.Append(FormarCadenaEspaciosBlanco(jerarquia));
            TrazaDerivacion.Append(NombreRegla);
            TrazaDerivacion.Append(Environment.NewLine);

        }
        private string FormarCadenaEspaciosBlanco(int jerarquia)
        {
            String EspaciosBlanco = "";
            for (int i = 1; i <= jerarquia; i++)
            {
                EspaciosBlanco = EspaciosBlanco + " | ";
            }
            return EspaciosBlanco;
        }

        private void FormarResultadoMorse(ComponenteLexico Componente)
        {
            switch (Componente.ObtenerCategoria())
            {
                case Categoria.LETRA_A:
                    Resultado.Append("A");
                    break;
                case Categoria.LETRA_B:
                    Resultado.Append("B");
                    break;
                case Categoria.LETRA_C:
                    Resultado.Append("C");
                    break;
                case Categoria.LETRA_D:
                    Resultado.Append("D");
                    break;
                case Categoria.LETRA_E:
                    Resultado.Append("E");
                    break;
                case Categoria.LETRA_F:
                    Resultado.Append("F");
                    break;
                case Categoria.LETRA_G:
                    Resultado.Append("G");
                    break;
                case Categoria.LETRA_H:
                    Resultado.Append("H");
                    break;
                case Categoria.LETRA_I:
                    Resultado.Append("I");
                    break;
                case Categoria.LETRA_J:
                    Resultado.Append("J");
                    break;
                case Categoria.LETRA_K:
                    Resultado.Append("K");
                    break;
                case Categoria.LETRA_L:
                    Resultado.Append("L");
                    break;
                case Categoria.LETRA_M:
                    Resultado.Append("M");
                    break;
                case Categoria.LETRA_N:
                    Resultado.Append("N");
                    break;
                case Categoria.LETRA_O:
                    Resultado.Append("O");
                    break;
                case Categoria.LETRA_P:
                    Resultado.Append("P");
                    break;
                case Categoria.LETRA_Q:
                    Resultado.Append("Q");
                    break;
                case Categoria.LETRA_R:
                    Resultado.Append("R");
                    break;
                case Categoria.LETRA_S:
                    Resultado.Append("S");
                    break;
                case Categoria.LETRA_T:
                    Resultado.Append("T");
                    break;
                case Categoria.LETRA_U:
                    Resultado.Append("U");
                    break;
                case Categoria.LETRA_V:
                    Resultado.Append("V");
                    break;
                case Categoria.LETRA_W:
                    Resultado.Append("W");
                    break;
                case Categoria.LETRA_X:
                    Resultado.Append("X");
                    break;
                case Categoria.LETRA_Y:
                    Resultado.Append("Y");
                    break;
                case Categoria.LETRA_Z:
                    Resultado.Append("Z");
                    break;
                case Categoria.LETRA_TILDE_A:
                    Resultado.Append("Á");
                    break;
                case Categoria.LETRA_TILDE_E:
                    Resultado.Append("É");
                    break;
                case Categoria.LETRA_TILDE_O:
                    Resultado.Append("Ó");
                    break;
                case Categoria.LETRA_ENYE:
                    Resultado.Append("Ñ");
                    break;
                case Categoria.COMA:
                    Resultado.Append(",");
                    break;
                case Categoria.PUNTO:
                    Resultado.Append(".");
                    break;
                case Categoria.INTERROGACION_CIERRA:
                    Resultado.Append("?");
                    break;
                case Categoria.INTERROGACION_ABRE:
                    Resultado.Append("¿");
                    break;
                case Categoria.COMILLA_SIMPLE:
                    Resultado.Append("'");
                    break;
                case Categoria.ADMIRACION_CIERRA:
                    Resultado.Append("¡");
                    break;
                case Categoria.ADMIRACION_ABRE:
                    Resultado.Append("!");
                    break;
                case Categoria.PARENTESIS_CIERRA:
                    Resultado.Append(")");
                    break;
                case Categoria.PARENTESIS_ABRE:
                    Resultado.Append("(");
                    break;
                case Categoria.LETRA_ET:
                    Resultado.Append("&");
                    break;
                case Categoria.DOS_PUNTOS:
                    Resultado.Append(":");
                    break;
                case Categoria.PUNTO_Y_COMA:
                    Resultado.Append(";");
                    break;
                case Categoria.IGUAL:
                    Resultado.Append("=");
                    break;
                case Categoria.MAS:
                    Resultado.Append("+");
                    break;
                case Categoria.GUION:
                    Resultado.Append("-");
                    break;
                case Categoria.GUION_BAJO:
                    Resultado.Append("_");
                    break;
                case Categoria.COMILLAS_DOBLES:
                    Resultado.Append("\"");
                    break;
                case Categoria.SIGNO_PESOS:
                    Resultado.Append("$");
                    break;
                case Categoria.ARROBA:
                    Resultado.Append("@");
                    break;
                case Categoria.NUMERO_CERO:
                    Resultado.Append("0");
                    break;
                case Categoria.NUMERO_UNO:
                    Resultado.Append("1");
                    break;
                case Categoria.NUMERO_DOS:
                    Resultado.Append("2");
                    break;
                case Categoria.NUMERO_TRES:
                    Resultado.Append("3");
                    break;
                case Categoria.NUMERO_CUATRO:
                    Resultado.Append("4");
                    break;
                case Categoria.NUMERO_CINCO:
                    Resultado.Append("5");
                    break;
                case Categoria.NUMERO_SEIS:
                    Resultado.Append("6");
                    break;
                case Categoria.NUMERO_SIETE:
                    Resultado.Append("7");
                    break;
                case Categoria.NUMERO_OCHO:
                    Resultado.Append("8");
                    break;
                case Categoria.NUMERO_NUEVE:
                    Resultado.Append("9");
                    break;
                case Categoria.BARRA_INCLINADA:
                    Resultado.Append("/");
                    break;
                case Categoria.ESPACIO:
                    Resultado.Append(" ");
                    break;
                default:
                    
                    break;
            }
        }
        private void FormarResultadoLatin(ComponenteLexico Componente)
        {
            switch (Componente.ObtenerCategoria())
            {
                case Categoria.LETRA_MORSE:
                    switch (Componente.ObtenerLexema().ToUpper())
                    {
                        case "A":
                            Resultado.Append(".- ");
                            break;
                        case "B":
                            Resultado.Append("-... ");
                            break;
                        case "C":
                            Resultado.Append("-.-. ");
                            break;
                        case "D":
                            Resultado.Append("-.. ");
                            break;
                        case "E":
                            Resultado.Append(". ");
                            break;
                        case "F":
                            Resultado.Append("..-. ");
                            break;
                        case "G":
                            Resultado.Append("--. ");
                            break;
                        case "H":
                            Resultado.Append(".... ");
                            break;
                        case "I":
                            Resultado.Append(".. ");
                            break;
                        case "J":
                            Resultado.Append(".--- ");
                            break;
                        case "K":
                            Resultado.Append("-.- ");
                            break;
                        case "L":
                            Resultado.Append(".-.. ");
                            break;
                        case "M":
                            Resultado.Append("-- ");
                            break;
                        case "N":
                            Resultado.Append("-. ");
                            break;
                        case "O":
                            Resultado.Append("--- ");
                            break;
                        case "P":
                            Resultado.Append(".--. ");
                            break;
                        case "Q":
                            Resultado.Append("--.- ");
                            break;
                        case "R":
                            Resultado.Append(".-. ");
                            break;
                        case "S":
                            Resultado.Append("... ");
                            break;
                        case "T":
                            Resultado.Append("- ");
                            break;
                        case "U":
                            Resultado.Append("..- ");
                            break;
                        case "V":
                            Resultado.Append("...- ");
                            break;
                        case "W":
                            Resultado.Append(".-- ");
                            break;
                        case "X":
                            Resultado.Append("-..- ");
                            break;
                        case "Y":
                            Resultado.Append("-.-- ");
                            break;
                        case "Z":
                            Resultado.Append("--.. ");
                            break;

                    }
                    break;
                case Categoria.NUMERO_MORSE:

                    switch (Componente.ObtenerLexema())
                    {
                        case "0":
                            Resultado.Append("----- ");
                            break;
                        case "1":
                            Resultado.Append(".---- ");
                            break;
                        case "2":
                            Resultado.Append("..--- ");
                            break;
                        case "3":
                            Resultado.Append("...-- ");
                            break;
                        case "4":
                            Resultado.Append("....- ");
                            break;
                        case "5":
                            Resultado.Append("..... ");
                            break;
                        case "6":
                            Resultado.Append("-.... ");
                            break;
                        case "7":
                            Resultado.Append("--... ");
                            break;
                        case "8":
                            Resultado.Append("---.. ");
                            break;
                        case "9":
                            Resultado.Append("----. ");
                            break;
                    }

                    break;
                case Categoria.PREGUNTA_ABRE_MORSE:
                    Resultado.Append("..--.. ");
                    break;
                case Categoria.PREGUNTA_CIERRA_MORSE:
                    Resultado.Append("..-.- ");
                    break;
                case Categoria.COMILLA_SIMPLE_MORSE:
                    Resultado.Append(".----. ");
                    break;
                case Categoria.ADMIRACION_ABRE_MORSE:
                    Resultado.Append("-.-.-- ");
                    break;
                case Categoria.ADMIRACION_CIERRA_MORSE:
                    Resultado.Append("--...- ");
                    break;
                case Categoria.BARRA_INCLINADA_MORSE:
                    Resultado.Append("-..-. ");
                    break;
                case Categoria.PARENTESIS_ABRE_MORSE:
                    Resultado.Append("-.--. ");
                    break;
                case Categoria.PARENTESIS_CIERRA_MORSE:
                    Resultado.Append("-.--.- ");
                    break;
                case Categoria.ET_MORSE:
                    Resultado.Append(".-... ");
                    break;
                case Categoria.DOS_PUNTOS_MORSE:
                    Resultado.Append("---... ");
                    break;
                case Categoria.PUNTO_Y_COMA_MORSE:
                    Resultado.Append("-.-.-. ");
                    break;
                case Categoria.IGUAL_MORSE:
                    Resultado.Append("-...- ");
                    break;
                case Categoria.MAS_MORSE:
                    Resultado.Append(".-.-. ");
                    break;
                case Categoria.GUION_MORSE:
                    Resultado.Append("-....- ");
                    break;
                case Categoria.GUION_BAJO_MORSE:
                    Resultado.Append("..--.- ");
                    break;
                case Categoria.COMILLAS_DOBLES_MORSE:
                    Resultado.Append(".-..-. ");
                    break;
                case Categoria.SIGNO_PESOS_MORSE:
                    Resultado.Append("...-..- ");
                    break;
                case Categoria.ARROBA_MORSE:
                    Resultado.Append(".--.-. ");
                    break;
                case Categoria.ESPACIO_MORSE:
                    Resultado.Append("/ ");
                    break;
                case Categoria.TILDE_A_MORSE:
                    Resultado.Append(".--.- ");
                    break;
                case Categoria.TILDE_E_MORSE:
                    Resultado.Append("..-.. ");
                    break;
                case Categoria.TILDE_O_MORSE:
                    Resultado.Append("---. ");
                    break;
                case Categoria.LETRA_ENYE_MORSE:
                    Resultado.Append("--.-- ");
                    break;
                case Categoria.PUNTO_MORSE:
                    Resultado.Append(".-.-.- ");
                    break;
                case Categoria.COMA_MORSE:
                    Resultado.Append("--..-- ");
                    break;
                case Categoria.FIN_DE_LINEA:
                    if (SaltoLinea)
                    {
                        Resultado.Append("/ ");
                        SaltoLinea = false;
                    }
                    break;
                default: 
                    Resultado.Append("#");
                    break;
            }
        }
    }
}
