using ExcelDataReader;
using System.Data;
using Lotofacil.Model;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Lotofacil {
    public partial class Form1 : Form {
        DataTableCollection tableCollection;
        Numeros numero = new Numeros();
        string valorExibir = "";
        public Form1() {
            InitializeComponent();
        }

        private void buttonImportar_Click(object sender, System.EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" }) {
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    textBoxFileName.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream)) {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration() {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            comboBoxGuia.Items.Clear();
                            foreach (DataTable table in tableCollection) {
                                comboBoxGuia.Items.Add(table.TableName);
                            }
                        }
                    }
                }
            }
        }

        private void comboBoxGuia_SelectedIndexChanged(object sender, System.EventArgs e) {
            DataTable dt = tableCollection[comboBoxGuia.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
            rastrearJogos();
        }

        private void rastrearJogos() {
            int quantidadesDeNumeros = 25;
            int quantidadeDeCelulas = 15;
            int linhaPassada = 1;

            foreach (DataGridViewRow row in dataGridView1.Rows) {
                int numeroDaCelula = 2;

                for (int i = 0; i < quantidadeDeCelulas; i++) {
                    int valorDaCelula = int.Parse(row.Cells[numeroDaCelula].Value.ToString());
                    int NumeroPesquisar = 1;

                    for (int j = 0; j < quantidadesDeNumeros; j++) {

                        if (NumeroPesquisar == valorDaCelula) {
                            if (NumeroPesquisar == 1) {
                                numero.N1++;
                            } else if (NumeroPesquisar == 2) {
                                numero.N2++;
                            } else if (NumeroPesquisar == 3) {
                                numero.N3++;
                            } else if (NumeroPesquisar == 4) {
                                numero.N4++;
                            } else if (NumeroPesquisar == 5) {
                                numero.N5++;
                            } else if (NumeroPesquisar == 6) {
                                numero.N6++;
                            } else if (NumeroPesquisar == 7) {
                                numero.N7++;
                            } else if (NumeroPesquisar == 8) {
                                numero.N8++;
                            } else if (NumeroPesquisar == 9) {
                                numero.N9++;
                            } else if (NumeroPesquisar == 10) {
                                numero.N10++;
                            } else if (NumeroPesquisar == 11) {
                                numero.N11++;
                            } else if (NumeroPesquisar == 12) {
                                numero.N12++;
                            } else if (NumeroPesquisar == 13) {
                                numero.N13++;
                            } else if (NumeroPesquisar == 14) {
                                numero.N14++;
                            } else if (NumeroPesquisar == 15) {
                                numero.N15++;
                            } else if (NumeroPesquisar == 16) {
                                numero.N16++;
                            } else if (NumeroPesquisar == 17) {
                                numero.N17++;
                            } else if (NumeroPesquisar == 18) {
                                numero.N18++;
                            } else if (NumeroPesquisar == 19) {
                                numero.N19++;
                            } else if (NumeroPesquisar == 20) {
                                numero.N20++;
                            } else if (NumeroPesquisar == 21) {
                                numero.N21++;
                            } else if (NumeroPesquisar == 22) {
                                numero.N22++;
                            } else if (NumeroPesquisar == 23) {
                                numero.N23++;
                            } else if (NumeroPesquisar == 24) {
                                numero.N24++;
                            } else if (NumeroPesquisar == 25) {
                                numero.N25++;
                            }
                            break;
                        } else {
                            NumeroPesquisar++;
                        }
                    }
                    numeroDaCelula++;
                }
                linhaPassada++;
            }

            labelB1.Text = numero.N1.ToString();
            labelB2.Text = numero.N2.ToString();
            labelB3.Text = numero.N3.ToString();
            labelB4.Text = numero.N4.ToString();
            labelB5.Text = numero.N5.ToString();
            labelB6.Text = numero.N6.ToString();
            labelB7.Text = numero.N7.ToString();
            labelB8.Text = numero.N8.ToString();
            labelB9.Text = numero.N9.ToString();
            labelB10.Text = numero.N10.ToString();
            labelB11.Text = numero.N11.ToString();
            labelB12.Text = numero.N12.ToString();
            labelB13.Text = numero.N13.ToString();
            labelB14.Text = numero.N14.ToString();
            labelB15.Text = numero.N15.ToString();
            labelB16.Text = numero.N16.ToString();
            labelB17.Text = numero.N17.ToString();
            labelB18.Text = numero.N18.ToString();
            labelB19.Text = numero.N19.ToString();
            labelB20.Text = numero.N20.ToString();
            labelB21.Text = numero.N21.ToString();
            labelB22.Text = numero.N22.ToString();
            labelB23.Text = numero.N23.ToString();
            labelB24.Text = numero.N24.ToString();
            labelB25.Text = numero.N25.ToString();

            criarSugestao();
        }

        private int verificarSeJaEscolheu(String pNumero, int pPosicao) {
            int retorno = 0;

            if (pNumero != "") {
                try {
                    int.Parse(pNumero);

                    if (int.Parse(pNumero) >= 1 && int.Parse(pNumero) <= 25) {

                        switch (pPosicao) {
                            case 1:
                                if (pNumero == textBoxE1.Text && pPosicao != 1) {
                                    retorno = 1;
                                }
                                break;
                            case 2:
                                if (pNumero == textBoxE1.Text) {
                                    retorno = 2;
                                }
                                break;
                            case 3:
                                if (pNumero == textBoxE1.Text || pNumero == textBoxE2.Text) {
                                    retorno = 3;
                                }
                                break;
                            case 4:
                                if (pNumero == textBoxE1.Text || pNumero == textBoxE2.Text || pNumero == textBoxE3.Text) {
                                    retorno = 4;
                                }
                                break;
                            case 5:
                                if (pNumero == textBoxE1.Text || pNumero == textBoxE2.Text || pNumero == textBoxE3.Text || pNumero == textBoxE4.Text) {
                                    retorno = 5;
                                }
                                break;
                            case 6:
                                if (pNumero == textBoxE1.Text || pNumero == textBoxE2.Text || pNumero == textBoxE3.Text || pNumero == textBoxE4.Text || pNumero == textBoxE5.Text) {
                                    retorno = 6;
                                }
                                break;
                            case 7:
                                if (pNumero == textBoxE1.Text || pNumero == textBoxE2.Text || pNumero == textBoxE3.Text || pNumero == textBoxE4.Text || pNumero == textBoxE5.Text || pNumero == textBoxE6.Text) {
                                    retorno = 7;
                                }
                                break;
                            case 8:
                                if (pNumero == textBoxE1.Text || pNumero == textBoxE2.Text || pNumero == textBoxE3.Text || pNumero == textBoxE4.Text || pNumero == textBoxE5.Text || pNumero == textBoxE6.Text || pNumero == textBoxE7.Text) {
                                    retorno = 8;
                                }
                                break;
                            case 9:
                                if (pNumero == textBoxE1.Text || pNumero == textBoxE2.Text || pNumero == textBoxE3.Text || pNumero == textBoxE4.Text || pNumero == textBoxE5.Text || pNumero == textBoxE6.Text || pNumero == textBoxE7.Text || pNumero == textBoxE8.Text) {
                                    retorno = 9;
                                }
                                break;
                            case 10:
                                if (pNumero == textBoxE1.Text || pNumero == textBoxE2.Text || pNumero == textBoxE3.Text || pNumero == textBoxE4.Text || pNumero == textBoxE5.Text || pNumero == textBoxE6.Text || pNumero == textBoxE7.Text || pNumero == textBoxE8.Text || pNumero == textBoxE9.Text) {
                                    retorno = 10;
                                }
                                break;
                            case 11:
                                if (pNumero == textBoxE1.Text || pNumero == textBoxE2.Text || pNumero == textBoxE3.Text || pNumero == textBoxE4.Text || pNumero == textBoxE5.Text || pNumero == textBoxE6.Text || pNumero == textBoxE7.Text || pNumero == textBoxE8.Text || pNumero == textBoxE9.Text || pNumero == textBoxE10.Text) {
                                    retorno = 11;
                                }
                                break;
                            case 12:
                                if (pNumero == textBoxE1.Text || pNumero == textBoxE2.Text || pNumero == textBoxE3.Text || pNumero == textBoxE4.Text || pNumero == textBoxE5.Text || pNumero == textBoxE6.Text || pNumero == textBoxE7.Text || pNumero == textBoxE8.Text || pNumero == textBoxE9.Text || pNumero == textBoxE10.Text || pNumero == textBoxE11.Text) {
                                    retorno = 12;
                                }
                                break;
                            case 13:
                                if (pNumero == textBoxE1.Text || pNumero == textBoxE2.Text || pNumero == textBoxE3.Text || pNumero == textBoxE4.Text || pNumero == textBoxE5.Text || pNumero == textBoxE6.Text || pNumero == textBoxE7.Text || pNumero == textBoxE8.Text || pNumero == textBoxE9.Text || pNumero == textBoxE10.Text || pNumero == textBoxE11.Text || pNumero == textBoxE12.Text) {
                                    retorno = 13;
                                }
                                break;
                            case 14:
                                if (pNumero == textBoxE1.Text || pNumero == textBoxE2.Text || pNumero == textBoxE3.Text || pNumero == textBoxE4.Text || pNumero == textBoxE5.Text || pNumero == textBoxE6.Text || pNumero == textBoxE7.Text || pNumero == textBoxE8.Text || pNumero == textBoxE9.Text || pNumero == textBoxE10.Text || pNumero == textBoxE11.Text || pNumero == textBoxE12.Text || pNumero == textBoxE13.Text) {
                                    retorno = 14;
                                }
                                break;
                            case 15:
                                if (pNumero == textBoxE1.Text || pNumero == textBoxE2.Text || pNumero == textBoxE3.Text || pNumero == textBoxE4.Text || pNumero == textBoxE5.Text || pNumero == textBoxE6.Text || pNumero == textBoxE7.Text || pNumero == textBoxE8.Text || pNumero == textBoxE9.Text || pNumero == textBoxE10.Text || pNumero == textBoxE11.Text || pNumero == textBoxE12.Text || pNumero == textBoxE13.Text || pNumero == textBoxE14.Text) {
                                    retorno = 15;
                                }
                                break;
                            case 16:
                                if (pNumero == textBoxE1.Text || pNumero == textBoxE2.Text || pNumero == textBoxE3.Text || pNumero == textBoxE4.Text || pNumero == textBoxE5.Text || pNumero == textBoxE6.Text || pNumero == textBoxE7.Text || pNumero == textBoxE8.Text || pNumero == textBoxE9.Text || pNumero == textBoxE10.Text || pNumero == textBoxE11.Text || pNumero == textBoxE12.Text || pNumero == textBoxE13.Text || pNumero == textBoxE14.Text || pNumero == textBoxE15.Text) {
                                    retorno = 16;
                                }
                                break;
                            case 17:
                                if (pNumero == textBoxE1.Text || pNumero == textBoxE2.Text || pNumero == textBoxE3.Text || pNumero == textBoxE4.Text || pNumero == textBoxE5.Text || pNumero == textBoxE6.Text || pNumero == textBoxE7.Text || pNumero == textBoxE8.Text || pNumero == textBoxE9.Text || pNumero == textBoxE10.Text || pNumero == textBoxE11.Text || pNumero == textBoxE12.Text || pNumero == textBoxE13.Text || pNumero == textBoxE14.Text || pNumero == textBoxE15.Text || pNumero == textBoxE16.Text) {
                                    retorno = 17;
                                }
                                break;
                            default:
                                retorno = 0;
                                break;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            }


            return retorno;
        }

        private void buttonFazerJogos_Click(object sender, System.EventArgs e) {

            if (textBoxE1.Text == "" || textBoxE2.Text == "" || textBoxE3.Text == "" || textBoxE4.Text == "" || textBoxE5.Text == "" || textBoxE6.Text == "" || textBoxE7.Text == "" || textBoxE8.Text == "" || textBoxE9.Text == "" || textBoxE10.Text == "" || textBoxE11.Text == "" || textBoxE12.Text == "" || textBoxE13.Text == "" || textBoxE14.Text == "" || textBoxE15.Text == "" || textBoxE16.Text == "" || textBoxE17.Text == "") {
                MessageBox.Show("Você precisa informar as 17 dezenas que deseja criar os jogos.");
            } else {
                List<int> valores = new List<int> { int.Parse(textBoxE1.Text), int.Parse(textBoxE2.Text), int.Parse(textBoxE3.Text), int.Parse(textBoxE4.Text), int.Parse(textBoxE5.Text), int.Parse(textBoxE6.Text), int.Parse(textBoxE7.Text), int.Parse(textBoxE8.Text), int.Parse(textBoxE9.Text), int.Parse(textBoxE10.Text), int.Parse(textBoxE11.Text), int.Parse(textBoxE12.Text), int.Parse(textBoxE13.Text), int.Parse(textBoxE14.Text), int.Parse(textBoxE15.Text), int.Parse(textBoxE16.Text), int.Parse(textBoxE17.Text) };
                int qtd = 15;
                Random rd = new Random();
                List<int> numeros = new List<int>();
                int number = 0;
                for (int i = 0; i < qtd; i++) {
                    number = rd.Next(1, 25);
                    while (number > 17 && !valores.Contains(number) || numeros.Contains(number)) {
                        number = rd.Next(1, 25);
                    }
                    numeros.Add(number);
                }
                int textboxResultado = 1;
                foreach (int v in numeros) {
                    if (textboxResultado == 1) {
                        textBoxR1.Text = v.ToString();
                        textboxResultado++;
                    } else if (textboxResultado == 2) {
                        textBoxR2.Text = v.ToString();
                        textboxResultado++;
                    } else if (textboxResultado == 3) {
                        textBoxR3.Text = v.ToString();
                        textboxResultado++;
                    } else if (textboxResultado == 4) {
                        textBoxR4.Text = v.ToString();
                        textboxResultado++;
                    } else if (textboxResultado == 5) {
                        textBoxR5.Text = v.ToString();
                        textboxResultado++;
                    } else if (textboxResultado == 6) {
                        textBoxR6.Text = v.ToString();
                        textboxResultado++;
                    } else if (textboxResultado == 7) {
                        textBoxR7.Text = v.ToString();
                        textboxResultado++;
                    } else if (textboxResultado == 8) {
                        textBoxR8.Text = v.ToString();
                        textboxResultado++;
                    } else if (textboxResultado == 9) {
                        textBoxR9.Text = v.ToString();
                        textboxResultado++;
                    } else if (textboxResultado == 10) {
                        textBoxR10.Text = v.ToString();
                        textboxResultado++;
                    } else if (textboxResultado == 11) {
                        textBoxR11.Text = v.ToString();
                        textboxResultado++;
                    } else if (textboxResultado == 12) {
                        textBoxR12.Text = v.ToString();
                        textboxResultado++;
                    } else if (textboxResultado == 13) {
                        textBoxR13.Text = v.ToString();
                        textboxResultado++;
                    } else if (textboxResultado == 14) {
                        textBoxR14.Text = v.ToString();
                        textboxResultado++;
                    } else if (textboxResultado == 15) {
                        textBoxR15.Text = v.ToString();
                        textboxResultado++;
                    }
                }
                criarSugestaoDeJogo();
            }
        }

        private bool validar(int posicao) {

            bool retornoFuncao = true;
            int retorno = 0;

            if (posicao == 1) {
                try {

                    if (textBoxE1.Text != "") {
                        if (int.Parse(textBoxE1.Text) >= 1 && int.Parse(textBoxE1.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE1.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }

                } catch (Exception) {
                    retorno = 19;
                }
            } else if (posicao == 2) {
                try {
                    if (textBoxE2.Text != "") {
                        if (int.Parse(textBoxE2.Text) >= 1 && int.Parse(textBoxE2.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE2.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            } else if (posicao == 3) {
                try {
                    if (textBoxE3.Text != "") {
                        if (int.Parse(textBoxE3.Text) >= 1 && int.Parse(textBoxE3.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE3.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            } else if (posicao == 4) {
                try {
                    if (textBoxE4.Text != "") {
                        if (int.Parse(textBoxE4.Text) >= 1 && int.Parse(textBoxE4.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE4.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            } else if (posicao == 5) {
                try {
                    if (textBoxE5.Text != "") {
                        if (int.Parse(textBoxE5.Text) >= 1 && int.Parse(textBoxE5.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE5.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            } else if (posicao == 6) {
                try {
                    if (textBoxE6.Text != "") {
                        if (int.Parse(textBoxE6.Text) >= 1 && int.Parse(textBoxE6.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE6.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            } else if (posicao == 7) {
                try {
                    if (textBoxE7.Text != "") {
                        if (int.Parse(textBoxE7.Text) >= 1 && int.Parse(textBoxE7.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE7.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            } else if (posicao == 8) {
                try {
                    if (textBoxE8.Text != "") {
                        if (int.Parse(textBoxE8.Text) >= 1 && int.Parse(textBoxE8.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE8.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            } else if (posicao == 9) {
                try {
                    if (textBoxE9.Text != "") {
                        if (int.Parse(textBoxE9.Text) >= 1 && int.Parse(textBoxE9.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE9.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            } else if (posicao == 10) {
                try {
                    if (textBoxE10.Text != "") {
                        if (int.Parse(textBoxE10.Text) >= 1 && int.Parse(textBoxE10.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE10.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            } else if (posicao == 11) {
                try {
                    if (textBoxE11.Text != "") {
                        if (int.Parse(textBoxE11.Text) >= 1 && int.Parse(textBoxE11.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE11.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            } else if (posicao == 12) {
                try {
                    if (textBoxE12.Text != "") {
                        if (int.Parse(textBoxE12.Text) >= 1 && int.Parse(textBoxE12.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE12.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            } else if (posicao == 13) {
                try {
                    if (textBoxE13.Text != "") {
                        if (int.Parse(textBoxE13.Text) >= 1 && int.Parse(textBoxE13.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE13.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            } else if (posicao == 14) {
                try {
                    if (textBoxE14.Text != "") {
                        if (int.Parse(textBoxE14.Text) >= 1 && int.Parse(textBoxE14.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE14.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            } else if (posicao == 15) {
                try {
                    if (textBoxE15.Text != "") {
                        if (int.Parse(textBoxE15.Text) >= 1 && int.Parse(textBoxE15.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE15.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            } else if (posicao == 16) {
                try {
                    if (textBoxE16.Text != "") {
                        if (int.Parse(textBoxE16.Text) >= 1 && int.Parse(textBoxE16.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE16.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            } else if (posicao == 17) {
                try {
                    if (textBoxE17.Text != "") {
                        if (int.Parse(textBoxE17.Text) >= 1 && int.Parse(textBoxE17.Text) <= 25) {
                            retorno = verificarSeJaEscolheu(textBoxE17.Text, posicao);
                        } else {
                            retorno = 18;
                        }
                    }
                } catch (Exception) {
                    retorno = 19;
                }
            }

            if (retorno == 18) {
                MessageBox.Show("Escolha um número entre 1 e 25, revise");
                retornoFuncao = false;
            } else if (retorno == 19) {
                MessageBox.Show("Você digitou um valor inválido");
                retornoFuncao = false;
            } else if (retorno >= 1 && retorno < 17) {
                MessageBox.Show("Você já escolheu esta dezena, revise.");
                retornoFuncao = false;
            }
            return retornoFuncao;
        }

        private void criarSugestaoDeJogo() {

            List<int> lista4 = new List<int>();

            for (int i = 0; i < 15; i++) {
                if (i == 0) {
                    lista4.Add(int.Parse(textBoxR1.Text));
                } else if (i == 1) {
                    lista4.Add(int.Parse(textBoxR2.Text));
                } else if (i == 2) {
                    lista4.Add(int.Parse(textBoxR3.Text));
                } else if (i == 3) {
                    lista4.Add(int.Parse(textBoxR4.Text));
                } else if (i == 4) {
                    lista4.Add(int.Parse(textBoxR5.Text));
                } else if (i == 5) {
                    lista4.Add(int.Parse(textBoxR6.Text));
                } else if (i == 6) {
                    lista4.Add(int.Parse(textBoxR7.Text));
                } else if (i == 7) {
                    lista4.Add(int.Parse(textBoxR8.Text));
                } else if (i == 8) {
                    lista4.Add(int.Parse(textBoxR9.Text));
                } else if (i == 9) {
                    lista4.Add(int.Parse(textBoxR10.Text));
                } else if (i == 10) {
                    lista4.Add(int.Parse(textBoxR11.Text));
                } else if (i == 11) {
                    lista4.Add(int.Parse(textBoxR12.Text));
                } else if (i == 12) {
                    lista4.Add(int.Parse(textBoxR13.Text));
                } else if (i == 13) {
                    lista4.Add(int.Parse(textBoxR14.Text));
                } else if (i == 14) {
                    lista4.Add(int.Parse(textBoxR15.Text));
                }
            }
            lista4.Sort();

            textBoxR1.Text = "";
            textBoxR2.Text = "";
            textBoxR3.Text = "";
            textBoxR4.Text = "";
            textBoxR5.Text = "";
            textBoxR6.Text = "";
            textBoxR7.Text = "";
            textBoxR8.Text = "";
            textBoxR9.Text = "";
            textBoxR10.Text = "";
            textBoxR11.Text = "";
            textBoxR12.Text = "";
            textBoxR13.Text = "";
            textBoxR14.Text = "";
            textBoxR15.Text = "";

            foreach (int valorRecuperado4 in lista4) {

                if (textBoxR1.Text == "") {
                    textBoxR1.Text = valorRecuperado4.ToString();
                } else if (textBoxR2.Text == "") {
                    textBoxR2.Text = valorRecuperado4.ToString();
                } else if (textBoxR3.Text == "") {
                    textBoxR3.Text = valorRecuperado4.ToString();
                } else if (textBoxR4.Text == "") {
                    textBoxR4.Text = valorRecuperado4.ToString();
                } else if (textBoxR5.Text == "") {
                    textBoxR5.Text = valorRecuperado4.ToString();
                } else if (textBoxR6.Text == "") {
                    textBoxR6.Text = valorRecuperado4.ToString();
                } else if (textBoxR7.Text == "") {
                    textBoxR7.Text = valorRecuperado4.ToString();
                } else if (textBoxR8.Text == "") {
                    textBoxR8.Text = valorRecuperado4.ToString();
                } else if (textBoxR9.Text == "") {
                    textBoxR9.Text = valorRecuperado4.ToString();
                } else if (textBoxR10.Text == "") {
                    textBoxR10.Text = valorRecuperado4.ToString();
                } else if (textBoxR11.Text == "") {
                    textBoxR11.Text = valorRecuperado4.ToString();
                } else if (textBoxR12.Text == "") {
                    textBoxR12.Text = valorRecuperado4.ToString();
                } else if (textBoxR13.Text == "") {
                    textBoxR13.Text = valorRecuperado4.ToString();
                } else if (textBoxR14.Text == "") {
                    textBoxR14.Text = valorRecuperado4.ToString();
                } else if (textBoxR15.Text == "") {
                    textBoxR15.Text = valorRecuperado4.ToString();
                }
            }



        }

        private void criarSugestao() {

            List<int> lista = new List<int>();
            List<int> lista2 = new List<int>();
            List<int> lista3 = new List<int>();
            List<int> lista4 = new List<int>();

            lista.Add(numero.N1);
            lista.Add(numero.N2);
            lista.Add(numero.N3);
            lista.Add(numero.N4);
            lista.Add(numero.N5);
            lista.Add(numero.N6);
            lista.Add(numero.N7);
            lista.Add(numero.N8);
            lista.Add(numero.N9);
            lista.Add(numero.N10);
            lista.Add(numero.N11);
            lista.Add(numero.N12);
            lista.Add(numero.N13);
            lista.Add(numero.N14);
            lista.Add(numero.N15);
            lista.Add(numero.N16);
            lista.Add(numero.N17);
            lista.Add(numero.N18);
            lista.Add(numero.N19);
            lista.Add(numero.N20);
            lista.Add(numero.N21);
            lista.Add(numero.N22);
            lista.Add(numero.N23);
            lista.Add(numero.N24);
            lista.Add(numero.N25);

            lista2.Add(numero.N1);
            lista2.Add(numero.N2);
            lista2.Add(numero.N3);
            lista2.Add(numero.N4);
            lista2.Add(numero.N5);
            lista2.Add(numero.N6);
            lista2.Add(numero.N7);
            lista2.Add(numero.N8);
            lista2.Add(numero.N9);
            lista2.Add(numero.N10);
            lista2.Add(numero.N11);
            lista2.Add(numero.N12);
            lista2.Add(numero.N13);
            lista2.Add(numero.N14);
            lista2.Add(numero.N15);
            lista2.Add(numero.N16);
            lista2.Add(numero.N17);
            lista2.Add(numero.N18);
            lista2.Add(numero.N19);
            lista2.Add(numero.N20);
            lista2.Add(numero.N21);
            lista2.Add(numero.N22);
            lista2.Add(numero.N23);
            lista2.Add(numero.N24);
            lista2.Add(numero.N25);

            // Ordena toda a lista de forma ascendente
            lista.Sort();
            lista.Reverse();

            foreach (int valorLista1 in lista) {
                int posicaoLista2 = 1;
                foreach (int valorLista2 in lista2) {
                    if (valorLista1 == valorLista2) {

                        if (!lista3.Contains(posicaoLista2)) {
                            lista3.Add(posicaoLista2);
                        }
                    }
                    posicaoLista2++;
                }
            }
            foreach (int valorRecuperado in lista3) {

                if (textBoxE1.Text == "") {
                    textBoxE1.Text = valorRecuperado.ToString();
                } else if (textBoxE2.Text == "") {
                    textBoxE2.Text = valorRecuperado.ToString();
                } else if (textBoxE3.Text == "") {
                    textBoxE3.Text = valorRecuperado.ToString();
                } else if (textBoxE4.Text == "") {
                    textBoxE4.Text = valorRecuperado.ToString();
                } else if (textBoxE5.Text == "") {
                    textBoxE5.Text = valorRecuperado.ToString();
                } else if (textBoxE6.Text == "") {
                    textBoxE6.Text = valorRecuperado.ToString();
                } else if (textBoxE7.Text == "") {
                    textBoxE7.Text = valorRecuperado.ToString();
                } else if (textBoxE8.Text == "") {
                    textBoxE8.Text = valorRecuperado.ToString();
                } else if (textBoxE9.Text == "") {
                    textBoxE9.Text = valorRecuperado.ToString();
                } else if (textBoxE10.Text == "") {
                    textBoxE10.Text = valorRecuperado.ToString();
                } else if (textBoxE11.Text == "") {
                    textBoxE11.Text = valorRecuperado.ToString();
                } else if (textBoxE12.Text == "") {
                    textBoxE12.Text = valorRecuperado.ToString();
                } else if (textBoxE13.Text == "") {
                    textBoxE13.Text = valorRecuperado.ToString();
                } else if (textBoxE14.Text == "") {
                    textBoxE14.Text = valorRecuperado.ToString();
                } else if (textBoxE15.Text == "") {
                    textBoxE15.Text = valorRecuperado.ToString();
                } else if (textBoxE16.Text == "") {
                    textBoxE16.Text = valorRecuperado.ToString();
                } else if (textBoxE17.Text == "") {
                    textBoxE17.Text = valorRecuperado.ToString();
                }
            }

            for (int i = 0; i < 17; i++) {
                if (i == 0) {
                    lista4.Add(int.Parse(textBoxE1.Text));
                } else if (i == 1) {
                    lista4.Add(int.Parse(textBoxE2.Text));
                } else if (i == 2) {
                    lista4.Add(int.Parse(textBoxE3.Text));
                } else if (i == 3) {
                    lista4.Add(int.Parse(textBoxE4.Text));
                } else if (i == 4) {
                    lista4.Add(int.Parse(textBoxE5.Text));
                } else if (i == 5) {
                    lista4.Add(int.Parse(textBoxE6.Text));
                } else if (i == 6) {
                    lista4.Add(int.Parse(textBoxE7.Text));
                } else if (i == 7) {
                    lista4.Add(int.Parse(textBoxE8.Text));
                } else if (i == 8) {
                    lista4.Add(int.Parse(textBoxE9.Text));
                } else if (i == 9) {
                    lista4.Add(int.Parse(textBoxE10.Text));
                } else if (i == 10) {
                    lista4.Add(int.Parse(textBoxE11.Text));
                } else if (i == 11) {
                    lista4.Add(int.Parse(textBoxE12.Text));
                } else if (i == 12) {
                    lista4.Add(int.Parse(textBoxE13.Text));
                } else if (i == 13) {
                    lista4.Add(int.Parse(textBoxE14.Text));
                } else if (i == 14) {
                    lista4.Add(int.Parse(textBoxE15.Text));
                } else if (i == 15) {
                    lista4.Add(int.Parse(textBoxE16.Text));
                } else if (i == 16) {
                    lista4.Add(int.Parse(textBoxE17.Text));
                }
            }
            lista4.Sort();

            textBoxE1.Text = "";
            textBoxE2.Text = "";
            textBoxE3.Text = "";
            textBoxE4.Text = "";
            textBoxE5.Text = "";
            textBoxE6.Text = "";
            textBoxE7.Text = "";
            textBoxE8.Text = "";
            textBoxE9.Text = "";
            textBoxE10.Text = "";
            textBoxE11.Text = "";
            textBoxE12.Text = "";
            textBoxE13.Text = "";
            textBoxE14.Text = "";
            textBoxE15.Text = "";
            textBoxE16.Text = "";
            textBoxE17.Text = "";

            foreach (int valorRecuperado4 in lista4) {

                if (textBoxE1.Text == "") {
                    textBoxE1.Text = valorRecuperado4.ToString();
                } else if (textBoxE2.Text == "") {
                    textBoxE2.Text = valorRecuperado4.ToString();
                } else if (textBoxE3.Text == "") {
                    textBoxE3.Text = valorRecuperado4.ToString();
                } else if (textBoxE4.Text == "") {
                    textBoxE4.Text = valorRecuperado4.ToString();
                } else if (textBoxE5.Text == "") {
                    textBoxE5.Text = valorRecuperado4.ToString();
                } else if (textBoxE6.Text == "") {
                    textBoxE6.Text = valorRecuperado4.ToString();
                } else if (textBoxE7.Text == "") {
                    textBoxE7.Text = valorRecuperado4.ToString();
                } else if (textBoxE8.Text == "") {
                    textBoxE8.Text = valorRecuperado4.ToString();
                } else if (textBoxE9.Text == "") {
                    textBoxE9.Text = valorRecuperado4.ToString();
                } else if (textBoxE10.Text == "") {
                    textBoxE10.Text = valorRecuperado4.ToString();
                } else if (textBoxE11.Text == "") {
                    textBoxE11.Text = valorRecuperado4.ToString();
                } else if (textBoxE12.Text == "") {
                    textBoxE12.Text = valorRecuperado4.ToString();
                } else if (textBoxE13.Text == "") {
                    textBoxE13.Text = valorRecuperado4.ToString();
                } else if (textBoxE14.Text == "") {
                    textBoxE14.Text = valorRecuperado4.ToString();
                } else if (textBoxE15.Text == "") {
                    textBoxE15.Text = valorRecuperado4.ToString();
                } else if (textBoxE16.Text == "") {
                    textBoxE16.Text = valorRecuperado4.ToString();
                } else if (textBoxE17.Text == "") {
                    textBoxE17.Text = valorRecuperado4.ToString();
                }
            }
            label3.Text = "Sugestão de 17 dezenas escolhidas pelo critério de mais vezes sorteadas. Obs: Você pode alterar";
        }

        private void textBoxE1_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(1)) {
                textBoxE2.Focus();
            } else {
                textBoxE1.Text = "";
                textBoxE1.Focus();
            }
        }

        private void textBoxE2_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(2)) {
                textBoxE3.Focus();
            } else {
                textBoxE2.Text = "";
                textBoxE2.Focus();
            }
        }

        private void textBoxE4_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(4)) {
                textBoxE5.Focus();
            } else {
                textBoxE4.Text = "";
                textBoxE4.Focus();
            }
        }

        private void textBoxE5_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(5)) {
                textBoxE6.Focus();
            } else {
                textBoxE5.Text = "";
                textBoxE5.Focus();
            }
        }

        private void textBoxE6_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(6)) {
                textBoxE7.Focus();
            } else {
                textBoxE6.Text = "";
                textBoxE6.Focus();
            }
        }

        private void textBoxE7_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(7)) {
                textBoxE8.Focus();
            } else {
                textBoxE7.Text = "";
                textBoxE7.Focus();
            }
        }

        private void textBoxE8_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(8)) {
                textBoxE9.Focus();
            } else {
                textBoxE8.Text = "";
                textBoxE8.Focus();
            }
        }

        private void textBoxE9_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(9)) {
                textBoxE10.Focus();
            } else {
                textBoxE9.Text = "";
                textBoxE9.Focus();
            }
        }

        private void textBoxE10_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(10)) {
                textBoxE11.Focus();
            } else {
                textBoxE10.Text = "";
                textBoxE10.Focus();
            }
        }

        private void textBoxE11_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(11)) {
                textBoxE12.Focus();
            } else {
                textBoxE11.Text = "";
                textBoxE11.Focus();
            }
        }

        private void textBoxE12_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(12)) {
                textBoxE13.Focus();
            } else {
                textBoxE12.Text = "";
                textBoxE12.Focus();
            }
        }

        private void textBoxE13_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(13)) {
                textBoxE14.Focus();
            } else {
                textBoxE13.Text = "";
                textBoxE13.Focus();
            }
        }

        private void textBoxE14_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(14)) {
                textBoxE15.Focus();
            } else {
                textBoxE14.Text = "";
                textBoxE14.Focus();
            }
        }

        private void textBoxE15_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(15)) {
                textBoxE16.Focus();
            } else {
                textBoxE15.Text = "";
                textBoxE15.Focus();
            }
        }

        private void textBoxE16_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(16)) {
                textBoxE17.Focus();
            } else {
                textBoxE16.Text = "";
                textBoxE16.Focus();
            }
        }

        private void textBoxE17_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(17)) {
                buttonFazerJogos.Focus();
            } else {
                textBoxE17.Text = "";
                textBoxE17.Focus();
            }
        }

        private void textBoxE3_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (validar(3)) {
                textBoxE4.Focus();
            } else {
                textBoxE3.Text = "";
                textBoxE3.Focus();
            }
        }

        private void textBoxE1_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void textBoxE2_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void textBoxE3_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void textBoxE4_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void textBoxE5_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void textBoxE6_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void textBoxE7_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void textBoxE8_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void textBoxE9_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void textBoxE10_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void textBoxE11_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void textBoxE12_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void textBoxE13_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void textBoxE14_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void textBoxE15_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void textBoxE16_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void textBoxE17_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                buttonFazerJogos.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e) {

            
            if (textBoxR1.Text.Length > 0) {
                int verifica = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows) {
                    List<int> jogoCapturado = new List<int>();
                    jogoCapturado.Add(int.Parse(row.Cells[2].Value.ToString()));
                    jogoCapturado.Add(int.Parse(row.Cells[3].Value.ToString()));
                    jogoCapturado.Add(int.Parse(row.Cells[4].Value.ToString()));
                    jogoCapturado.Add(int.Parse(row.Cells[5].Value.ToString()));
                    jogoCapturado.Add(int.Parse(row.Cells[6].Value.ToString()));
                    jogoCapturado.Add(int.Parse(row.Cells[7].Value.ToString()));
                    jogoCapturado.Add(int.Parse(row.Cells[8].Value.ToString()));
                    jogoCapturado.Add(int.Parse(row.Cells[9].Value.ToString()));
                    jogoCapturado.Add(int.Parse(row.Cells[10].Value.ToString()));
                    jogoCapturado.Add(int.Parse(row.Cells[11].Value.ToString()));
                    jogoCapturado.Add(int.Parse(row.Cells[12].Value.ToString()));
                    jogoCapturado.Add(int.Parse(row.Cells[13].Value.ToString()));
                    jogoCapturado.Add(int.Parse(row.Cells[14].Value.ToString()));
                    jogoCapturado.Add(int.Parse(row.Cells[15].Value.ToString()));
                    jogoCapturado.Add(int.Parse(row.Cells[16].Value.ToString()));

                    if (jogoCapturado.Contains(int.Parse(textBoxR1.Text))) {
                        if (jogoCapturado.Contains(int.Parse(textBoxR2.Text))) {
                            if (jogoCapturado.Contains(int.Parse(textBoxR3.Text))) {
                                if (jogoCapturado.Contains(int.Parse(textBoxR4.Text))) {
                                    if (jogoCapturado.Contains(int.Parse(textBoxR5.Text))) {
                                        if (jogoCapturado.Contains(int.Parse(textBoxR6.Text))) {
                                            if (jogoCapturado.Contains(int.Parse(textBoxR7.Text))) {
                                                if (jogoCapturado.Contains(int.Parse(textBoxR8.Text))) {
                                                    if (jogoCapturado.Contains(int.Parse(textBoxR9.Text))) {
                                                        if (jogoCapturado.Contains(int.Parse(textBoxR10.Text))) {
                                                            if (jogoCapturado.Contains(int.Parse(textBoxR11.Text))) {
                                                                if (jogoCapturado.Contains(int.Parse(textBoxR12.Text))) {
                                                                    if (jogoCapturado.Contains(int.Parse(textBoxR13.Text))) {
                                                                        if (jogoCapturado.Contains(int.Parse(textBoxR14.Text))) {
                                                                            if (jogoCapturado.Contains(int.Parse(textBoxR15.Text))) {
                                                                                MessageBox.Show("Este jogo já saiu no concurso: " + row.Cells[0].Value.ToString());
                                                                                verifica = int.Parse(row.Cells[0].Value.ToString());
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (verifica == 0) {
                    MessageBox.Show("Este jogo nunca saiu ainda!!!");
                }
            } else {
                MessageBox.Show("Para realizar esta função, você precisa simular um jogo.");
            }            
        }

        private void verificarSeJaSAiu() {



        }

        private void buttonAlterar_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://programandosolucoes.com/");
        }
    }
}
