﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using lectorArchivo.Analizador;
using lectorArchivo.GestorErrores;
using lectorArchivo.Tablas;
using lectorArchivo.Transversal;
using lectorArchivo.AnalisisSintactico;

namespace lectorArchivo
{

   public partial class Form1 : Form
    {
        Boolean opcion;
        Boolean depurar =false;
        public Form1()
        {
            InitializeComponent();



        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textRuta_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textRuta.Text = buscar.FileName;
            }

        }
        private void Resetear()
        {
            Cache.obtenerCache().Limpiar();
            ManejadorErrores.Limpiar();
            TablaMaestra.Limpiar();
            dataDummys.Rows.Clear();
            dataSimbolos.Rows.Clear();
            dataLiterales.Rows.Clear();
            dataPalabraReservada.Rows.Clear();
            dataErroresLexicos.Rows.Clear();
            dataErroresSeman.Rows.Clear();
            dataErroresSintac.Rows.Clear();
        }

        private void botonCargarInfo_Click(object sender, EventArgs e)
        {

        }

        private void cargarInfoConsola_Click(object sender, EventArgs e)
        {
            String[] lineasEntradas = entradaDatosConsola.Lines;
            String[] lineasSalidas = lineasEntradas;
            for (int i = 0; i < lineasEntradas.Length; i++)
            {
                lineasSalidas[i] = i + " -> " + lineasEntradas[i];
            }
            salidaDatos.Lines = lineasSalidas;
            Resetear();
            for (int i = 0; i < lineasEntradas.Count(); i++)
            {
                Linea.Crear(i + 1, lineasEntradas[i]);
            }
            try
            {
                AnalizadorLexico analizador = new AnalizadorLexico();
                ComponenteLexico componente = analizador.Analizador(true);
                while (!componente.ObtenerCategoria().Equals(Categoria.FIN_DE_ARCHIVO))
                {
                 //   MessageBox.Show(componente.ToString());

                    componente = analizador.Analizador(true);

                }
                if (ManejadorErrores.HayErrores())
                {
                    MessageBox.Show("El proceso de compilacion ha finalizado con errores");
                }
                else
                {
                    MessageBox.Show("El proceso de compilacion ha finalizado exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            salidaDatos.Lines = lineasSalidas.ToArray();
        }

        private void checkConsola_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();

            if (checkConsola.Checked)
            {
                entradaDatosConsola.Enabled = true;
                checkArchivo.Enabled = false;
                cargarInfoConsola.Enabled = true;
                botonLimpiar.Enabled = true;

            }
            else
            {
                entradaDatosConsola.Enabled = false;
                checkArchivo.Enabled = true;
                cargarInfoConsola.Enabled = false;
                botonLimpiar.Enabled = false;
            }

        }
 

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            textRuta.Clear();
            entradaDatosConsola.Clear();
            salidaDatos.Clear();
            dataDummys.Rows.Clear();
            dataSimbolos.Rows.Clear();
            dataLiterales.Rows.Clear();
            dataPalabraReservada.Rows.Clear();
            dataErroresLexicos.Rows.Clear();
            dataErroresSeman.Rows.Clear();
            dataErroresSintac.Rows.Clear();
        }

        private void tabIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkArchivo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkArchivo.Checked)
            {
                checkConsola.Enabled = false;
            }
            else
            {
                checkConsola.Enabled = true;
            }

           
        }

        private void botonBuscar_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textRuta.Text = buscar.FileName;
            }
        }

        private void botonCargarInfo_Click_1(object sender, EventArgs e)
        {
            String ruta = textRuta.Text;
            StreamReader lector = new StreamReader(@"" + ruta);
            List<String> lineasEntrada = new List<string>();

            String lineaActual;

            while ((lineaActual = lector.ReadLine()) != null)
            {
                lineasEntrada.Add(lineaActual);
            }
            //salidaDatos.Lines = lineasEntrada.ToArray();
            salidaDatos.Clear();
            Resetear();
            for (int i = 0; i < lineasEntrada.Count(); i++)
            {
                Cache.obtenerCache().AgregarLinea(lineasEntrada[i]);
            }
            try
            {
                //AnalizadorLexico analizador = new AnalizadorLexico();
                AnalizadorSintactico AnaSin = new AnalizadorSintactico();
                Dictionary<string, object> Resultados = AnaSin.Analizar(depurar, opcion);
                ComponenteLexico Componente = (ComponenteLexico)Resultados["COMPONENTE"];
                string Resultado = Convert.ToString(Resultados["RESULTADO"]);

                //while (!Componente.ObtenerCategoria().Equals(Categoria.FIN_DE_ARCHIVO))
                //{
                //    MessageBox.Show(Componente.ToString());

                //    Componente = analizador.Analizar();


                //}
                LlenarTablas();
                if (ManejadorErrores.HayErrores())
                {
                    MessageBox.Show("Hay problemas de compilacion. Revise la información de los errores encontrados...");
                }
                else if (Categoria.FIN_DE_ARCHIVO.Equals(Componente.ObtenerCategoria()))
                {
                    MessageBox.Show("El programa se encuentra bien escrito");
                    //MessageBox.Show(Resultado);
                    salidaDatos.Text = Resultado;


                }
                else
                {
                    MessageBox.Show("Aunque el programa se encuentra bien escrito, faltaron componente por evaluar...");
                }
            }
            catch (Exception ex)
            {
                LlenarTablas();
                MessageBox.Show(ex.Message);
            }


        }

        private void checkConsola_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkConsola.Checked)
            {
                checkArchivo.Enabled = false;
            }
            else
            {
                checkArchivo.Enabled = true;
            }

         
        }

        private void botonLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();

        }

        private void cargarInfoConsola_Click_1(object sender, EventArgs e)
        {
            String[] lineasEntradas = entradaDatosConsola.Lines;
            //salidaDatos.Lines = lineasEntradas;
            salidaDatos.Clear();
            Resetear();
            for (int i = 0; i < lineasEntradas.Length; i++)
            {
                Cache.obtenerCache().AgregarLinea(lineasEntradas[i]);
            }
            try
            {
                //AnalizadorLexico analizador = new AnalizadorLexico();
                AnalizadorSintactico AnaSin = new AnalizadorSintactico();
                Dictionary<string, object> Resultados = AnaSin.Analizar(depurar, opcion);
                ComponenteLexico Componente = (ComponenteLexico)Resultados["COMPONENTE"];
                string Resultado = Convert.ToString(Resultados["RESULTADO"]);

                //while (!Componente.ObtenerCategoria().Equals(Categoria.FIN_DE_ARCHIVO))
                //{
                //    MessageBox.Show(Componente.ToString());

                //    Componente = analizador.Analizar();


                //}
                LlenarTablas();
                if (ManejadorErrores.HayErrores())
                {
                    MessageBox.Show("Hay problemas de compilacion. Revise la información de los errores encontrados...");
                }
                else if (Categoria.FIN_DE_ARCHIVO.Equals(Componente.ObtenerCategoria()))
                {
                    MessageBox.Show("El programa se encuentra bien escrito");
                    //MessageBox.Show(Resultado);
                    salidaDatos.Text = Resultado;
                    

                }
                else
                {
                    MessageBox.Show("Aunque el programa se encuentra bien escrito, faltaron componente por evaluar...");
                }
            }
            catch (Exception ex)
            {
                LlenarTablas();
                MessageBox.Show(ex.Message);
            }


        }
        private void LlenarTablas()
        {
            List<ComponenteLexico> listaSimbolo = TablaSimbolos.ObtenerSimbolos();
            for (int i = 0; i < listaSimbolo.Count; i++)
            {
                dataSimbolos.Rows.Add(listaSimbolo[i].ObtenerLexema(), listaSimbolo[i].ObtenerCategoria(), listaSimbolo[i].ObtenerNumeroLinea(), listaSimbolo[i].ObetenerPosicionInicial(), listaSimbolo[i].ObtenerPosicionFinal());

            }
            listaSimbolo = TablaPalabraReservadas.ObtenerSimbolos();
            for (int i = 0; i < listaSimbolo.Count; i++)
            {
                dataPalabraReservada.Rows.Add(listaSimbolo[i].ObtenerLexema(), listaSimbolo[i].ObtenerCategoria(), listaSimbolo[i].ObtenerNumeroLinea(), listaSimbolo[i].ObetenerPosicionInicial(), listaSimbolo[i].ObtenerPosicionFinal());

            }
            listaSimbolo = TablaLiterales.ObtenerLiterales();
            for (int i = 0; i < listaSimbolo.Count; i++)
            {
                dataLiterales.Rows.Add(listaSimbolo[i].ObtenerLexema(), listaSimbolo[i].ObtenerCategoria(), listaSimbolo[i].ObtenerNumeroLinea(), listaSimbolo[i].ObetenerPosicionInicial(), listaSimbolo[i].ObtenerPosicionFinal());

            }
            listaSimbolo = TablaDummys.ObtenerDummys();
            for (int i = 0; i < listaSimbolo.Count; i++)
            {
                dataDummys.Rows.Add(listaSimbolo[i].ObtenerLexema(), listaSimbolo[i].ObtenerCategoria(), listaSimbolo[i].ObtenerNumeroLinea(), listaSimbolo[i].ObetenerPosicionInicial(), listaSimbolo[i].ObtenerPosicionFinal());

            }

            List<Error> listaErrores = ManejadorErrores.ObtenerErroresLexicos();
            for (int i = 0; i < listaErrores.Count; i++)
            {
                dataErroresLexicos.Rows.Add(listaErrores[i].ObtenerLexema(), listaErrores[i].ObtenerCategoria(), listaErrores[i].ObtenerNumeroLinea(), listaErrores[i].ObetenerPosicionInicial(), listaErrores[i].ObtenerPosicionFinal(),
                    listaErrores[i].ObtenerFalla(), listaErrores[i].ObtenerCausa(), listaErrores[i].ObtenerSolucion());

            }

            listaErrores = ManejadorErrores.ObtenerErroresSintatacticos();
            for (int i = 0; i < listaErrores.Count; i++)
            {
                dataErroresSintac.Rows.Add(listaErrores[i].ObtenerLexema(), listaErrores[i].ObtenerCategoria(), listaErrores[i].ObtenerNumeroLinea(), listaErrores[i].ObetenerPosicionInicial(), listaErrores[i].ObtenerPosicionFinal(),
                    listaErrores[i].ObtenerFalla(), listaErrores[i].ObtenerCausa(), listaErrores[i].ObtenerSolucion());

            }
            listaErrores = ManejadorErrores.ObtenerErroresSemanticos();
            for (int i = 0; i < listaErrores.Count; i++)
            {
                dataErroresSeman.Rows.Add(listaErrores[i].ObtenerLexema(), listaErrores[i].ObtenerCategoria(), listaErrores[i].ObtenerNumeroLinea(), listaErrores[i].ObetenerPosicionInicial(), listaErrores[i].ObtenerPosicionFinal(),
                    listaErrores[i].ObtenerFalla(), listaErrores[i].ObtenerCausa(), listaErrores[i].ObtenerSolucion());

            }

        }

        private void MorseLatin_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();

            if (MorseLatin.Checked && checkConsola.Checked)
            {
                opcion = true;
                entradaDatosConsola.Enabled = true;
                checkArchivo.Enabled = false;
                cargarInfoConsola.Enabled = true;
                botonLimpiar.Enabled = true;
                LatinMorse.Enabled = false;
                checkConsola.Enabled = false;
            }
            else if (MorseLatin.Checked && checkArchivo.Checked)
            {
                opcion = true;
                textRuta.Enabled = true;
                botonBuscar.Enabled = true;
                botonCargarInfo.Enabled = true;
                botonLimpiar.Enabled = true;
                checkConsola.Enabled = false;
                LatinMorse.Enabled = false;
                checkArchivo.Enabled = false;
            }
            else if(!MorseLatin.Checked && checkArchivo.Checked)
            {
                entradaDatosConsola.Enabled = false;
                checkArchivo.Enabled = true;
                cargarInfoConsola.Enabled = false;
                botonLimpiar.Enabled = false;
                LatinMorse.Enabled = true;
                botonBuscar.Enabled = false;
                botonCargarInfo.Enabled = false;
            }
            else if (!MorseLatin.Checked && checkConsola.Checked)
            {
                entradaDatosConsola.Enabled = false;
                checkConsola.Enabled = true;
                cargarInfoConsola.Enabled = false;
                botonLimpiar.Enabled = false;
                LatinMorse.Enabled = true;
                botonBuscar.Enabled = false;
                botonCargarInfo.Enabled = false;
            }
        }

        private void LatinMorse_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();

            if (LatinMorse.Checked && checkConsola.Checked)
            {
                opcion = false;
                entradaDatosConsola.Enabled = true;
                checkArchivo.Enabled = false;
                cargarInfoConsola.Enabled = true;
                botonLimpiar.Enabled = true;
                MorseLatin.Enabled = false;
                checkConsola.Enabled = false;
            }
            else if (LatinMorse.Checked && checkArchivo.Checked)
            {
                opcion = false;
                textRuta.Enabled = true;
                botonBuscar.Enabled = true;
                botonCargarInfo.Enabled = true;
                botonLimpiar.Enabled = true;
                checkConsola.Enabled = false;
                MorseLatin.Enabled = false;
                checkArchivo.Enabled = false;
            }
            else if (!LatinMorse.Checked && checkArchivo.Checked)
            {
                entradaDatosConsola.Enabled = false;
                checkArchivo.Enabled = true;
                cargarInfoConsola.Enabled = false;
                botonLimpiar.Enabled = false;
                LatinMorse.Enabled = true;
                MorseLatin.Enabled = true;
                botonBuscar.Enabled = false;
                botonCargarInfo.Enabled = false;
            }
            else if (!LatinMorse.Checked && checkConsola.Checked)
            {
                entradaDatosConsola.Enabled = false;
                checkConsola.Enabled = true;
                cargarInfoConsola.Enabled = false;
                botonLimpiar.Enabled = false;
                LatinMorse.Enabled = true;
                MorseLatin.Enabled = true;
                botonBuscar.Enabled = false;
                botonCargarInfo.Enabled = false;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDepurar.Checked)
            {
                depurar = true;
            }
            else
            {
                depurar = false;
            }
        }
    }
}
