﻿namespace TrabalhoOrientadoAObjetos
{
    public partial class MainPage : ContentPage
    {
        private VeiculoRepositorio veiculoRepositorio = new();

        private string localRetirada;
        private DateTime dataRetirada;
        private TimeSpan horaRetirada;
        private DateTime dataDevolucao;
        private TimeSpan horaDevolucao;
        private string residencia;

        public MainPage()
        {
            InitializeComponent();

            localRetirada = string.Empty;
            dataRetirada = DateTime.Now;
            horaRetirada = DateTime.Now.TimeOfDay;
            dataDevolucao = DateTime.Now;
            horaDevolucao = DateTime.Now.TimeOfDay;
            residencia = "Brasil";
        }

        private void OnPesquisarClicked(object sender, EventArgs e)
        {
            localRetirada = entryLocalRetirada.Text;
            dataRetirada = datePickerRetirada.Date;
            horaRetirada = timePickerRetirada.Time;
            dataDevolucao = datePickerDevolucao.Date;
            horaDevolucao = timePickerDevolucao.Time;

            if (pickerResidencia.SelectedItem != null)
            {
                residencia = pickerResidencia.SelectedItem.ToString();
            }
            else
            {
                residencia = "Brasil";
            }

            string resultado = $"Local de Retirada: {localRetirada}\n" +
                               $"Data de Retirada: {dataRetirada.ToShortDateString()} às {horaRetirada}\n" +
                               $"Data de Devolução: {dataDevolucao.ToShortDateString()} às {horaDevolucao}\n" +
                               $"Residência: {residencia}";

            DisplayAlert("Opções Selecionadas", resultado, "OK");
        }
    }
}
