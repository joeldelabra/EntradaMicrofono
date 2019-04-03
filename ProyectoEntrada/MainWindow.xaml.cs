﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using NAudio.Wave.DSP



namespace ProyectoEntrada
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        WaveIn waveIn;

        public MainWindow()
        {
            InitializeComponent();
            LlenarComboDispositivo();
        }

        public void LlenarComboDispositivo()
        {
            for(int i=0; i<WaveIn.DeviceCount; i++)
            {
                WaveInCapabilities capacidades = WaveInCapabilities.GetCapabilitie(i);
                cmbDispositivos.Items.Add(capacidades.ProductName);
            }

            cmbDispositivos.SelectedIndex = 0;
        }

        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            waveIn = new WaveIn();
            //Formato de audio
            waveIn.WaveFormat ? new WaveFormat(44100,16,1);

            // Configurar el buffer
            waveIn.BufferMilliseconds = 250;

            //
        }
    }
}
