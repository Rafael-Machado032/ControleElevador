using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ControleElevador
{
    public class Controle:IElevadorService
    {
        public int andar { get; set; }
        public string elevador { get; set; }
        public string turno { get; set; }



        public List<int> andarMenosUtilizado()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Input.json");
            var control = JsonConvert.DeserializeObject<List<Controle>>(json);
            List<int> andarParado = new List<int>();
            int[] andarContador = new int[16];
            int andarMnor=15;
            int andarMenosU=0;

            for (int i = 0; i < control.Count; i++)
            {
                andarParado.Add(control[i].andar);
            }

            for (int i = 0; i < control.Count; i++)
            {
                switch (andarParado[i])
                {
                    case 0:
                        andarContador[0]++;
                        break;
                    case 1:
                        andarContador[1]++;
                        break;
                    case 2:
                        andarContador[2]++;
                        break;
                    case 3:
                        andarContador[3]++;
                        break;
                    case 4:
                        andarContador[4]++;
                        break;
                    case 5:
                        andarContador[5]++;
                        break;
                    case 6:
                        andarContador[6]++;
                        break;
                    case 7:
                        andarContador[7]++;
                        break;
                    case 8:
                        andarContador[8]++;
                        break;
                    case 9:
                        andarContador[9]++;
                        break;
                    case 10:
                        andarContador[10]++;
                        break;
                    case 11:
                        andarContador[11]++;
                        break;
                    case 12:
                        andarContador[12]++;
                        break;
                    case 13:
                        andarContador[13]++;
                        break;
                    case 14:
                        andarContador[14]++;
                        break;
                    case 15:
                        andarContador[15]++;
                        break;
                }


            }
            for (int a = 0; a <16; a++)
            {
                if (andarContador[a]<andarMnor)
                {
                    andarMnor = andarContador[a];
                    andarMenosU = a;
                }
            }
            Console.WriteLine("O andar menos utilizado é " + andarMenosU + " com " + andarMnor + " parada(s).");
            
            Console.ReadKey();
            
            throw new NotImplementedException();
        }

        public List<char> elevadorMaisFrequentado()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Input.json");
            var control = JsonConvert.DeserializeObject<List<Controle>>(json);
            List<string> elevadorParado = new List<string>();
            int[] elevadorContador = new int[5];
            int elevadorMaior = 0;
            

            for (int i = 0; i < control.Count; i++)
            {
                elevadorParado.Add(control[i].elevador);
                
            }

            for (int i = 0; i < control.Count; i++)
            {
                switch (elevadorParado[i])
                {
                    case "A":
                        elevadorContador[0]++;
                        break;
                    case "B":
                        elevadorContador[1]++;
                        break;
                    case "C":
                        elevadorContador[2]++;
                        break;
                    case "D":
                        elevadorContador[3]++;
                        break;
                    case "E":
                        elevadorContador[4]++;
                        break;
                    
                }

            }
            for (int a = 0; a < 5; a++)
            {
                if (elevadorContador[a] > elevadorMaior)
                {
                    elevadorMaior = elevadorContador[a];
                    if (a==0)
                    {
                        elevadorParado[5] = "A";
                    }
                    else
                    {
                        if (a == 1)
                        {
                            elevadorParado[5] = "B";
                        }
                        else
                        {
                            if (a == 2)
                            {
                                elevadorParado[5] = "C";
                            }
                            else
                            {
                                if (a == 3)
                                {
                                    elevadorParado[5] = "D";
                                }
                                else
                                {
                                        elevadorParado[5] = "E";
                                }
                            }
                        }
                    }
                }
            } 
       
            Console.WriteLine("O Elevador mais utilizado é " + elevadorParado[5] + " com uso de " + elevadorMaior + " veze(s).");

            Console.ReadKey();
            throw new NotImplementedException();
        }

        public List<char> elevadorMenosFrequentado()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Input.json");
            var control = JsonConvert.DeserializeObject<List<Controle>>(json);
            List<string> elevadorParado = new List<string>();
            int[] elevadorContador = new int[5];
            int elevadorMenor = control.Count;
            

            for (int i = 0; i < control.Count; i++)
            {
                elevadorParado.Add(control[i].elevador);
            }

            for (int i = 0; i < control.Count; i++)
            {
                switch (elevadorParado[i])
                {
                    case "A":
                        elevadorContador[0]++;
                        break;
                    case "B":
                        elevadorContador[1]++;
                        break;
                    case "C":
                        elevadorContador[2]++;
                        break;
                    case "D":
                        elevadorContador[3]++;
                        break;
                    case "E":
                        elevadorContador[4]++;
                        break;

                }

            }
            for (int a = 0; a < 5; a++)
            {
                if (elevadorContador[a] < elevadorMenor)
                {
                    elevadorMenor = elevadorContador[a];
                    if (a == 0)
                    {
                        elevadorParado[5] = "A";
                    }
                    else
                    {
                        if (a == 1)
                        {
                            elevadorParado[5] = "B";
                        }
                        else
                        {
                            if (a == 2)
                            {
                                elevadorParado[5] = "C";
                            }
                            else
                            {
                                if (a == 3)
                                {
                                    elevadorParado[5] = "D";
                                }
                                else
                                {
                                    elevadorParado[5] = "E";
                                }
                            }
                        }
                    }
                }

            }
            Console.WriteLine("O Elevador menos utilizado é " + elevadorParado[5] + " com uso de " + elevadorMenor + " veze(s).");

            Console.ReadKey();
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorA()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Input.json");
            var control = JsonConvert.DeserializeObject<List<Controle>>(json);
            int elevadorContador = 0;
            float res = 0;
            for (int i = 0; i < control.Count; i++)
            {
                if (control[i].elevador=="A")
                {
                    elevadorContador++;
                }
            }
            res = (elevadorContador * 100) / control.Count;
            Console.WriteLine("O Elevador A é ultilizado  " + res + "% das vezes");
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorB()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Input.json");
            var control = JsonConvert.DeserializeObject<List<Controle>>(json);
            int elevadorContador = 0;
            float res = 0;
            for (int i = 0; i < control.Count; i++)
            {
                if (control[i].elevador == "B")
                {
                    elevadorContador++;
                }
            }
            res = (elevadorContador * 100) / control.Count;
            Console.WriteLine("O Elevador A é ultilizado  " + res + "% das vezes");
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorC()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Input.json");
            var control = JsonConvert.DeserializeObject<List<Controle>>(json);
            int elevadorContador = 0;
            float res = 0;
            for (int i = 0; i < control.Count; i++)
            {
                if (control[i].elevador == "C")
                {
                    elevadorContador++;
                }
            }
            res = (elevadorContador * 100) / control.Count;
            Console.WriteLine("O Elevador A é ultilizado  " + res + "% das vezes");
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorD()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Input.json");
            var control = JsonConvert.DeserializeObject<List<Controle>>(json);
            int elevadorContador = 0;
            float res = 0;
            for (int i = 0; i < control.Count; i++)
            {
                if (control[i].elevador == "D")
                {
                    elevadorContador++;
                }
            }
            res = (elevadorContador * 100) / control.Count;
            Console.WriteLine("O Elevador A é ultilizado  " + res + "% das vezes");
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorE()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Input.json");
            var control = JsonConvert.DeserializeObject<List<Controle>>(json);
            int elevadorContador = 0;
            float res = 0F;
            for (int i = 0; i < control.Count; i++)
            {
                if (control[i].elevador == "E")
                {
                    elevadorContador++;
                }
            }
            res = (elevadorContador * 100) / control.Count;
            Console.WriteLine("O Elevador A é ultilizado  " + res + "% das vezes");
            throw new NotImplementedException();
        }

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Input.json");
            var control = JsonConvert.DeserializeObject<List<Controle>>(json);
            List<string> elevadorParado = new List<string>();
            int[] elevadorContador = new int[5];
            int elevadorMaior = 0;
            int[] turnoContador = new int[3];
            int turnoMaior = 0;
            int turnoMaisU = 0;
            string turnoAtual="0";



            for (int i = 0; i < control.Count; i++)
            {
                elevadorParado.Add(control[i].elevador);

            }

            for (int i = 0; i < control.Count; i++)
            {
                switch (elevadorParado[i])
                {
                    case "A":
                        elevadorContador[0]++;
                        break;
                    case "B":
                        elevadorContador[1]++;
                        break;
                    case "C":
                        elevadorContador[2]++;
                        break;
                    case "D":
                        elevadorContador[3]++;
                        break;
                    case "E":
                        elevadorContador[4]++;
                        break;

                }

            }
            for (int a = 0; a < 5; a++)
            {
                if (elevadorContador[a] > elevadorMaior)
                {
                    elevadorMaior = elevadorContador[a];
                    if (a == 0)
                    {
                        elevadorParado[5] = "A";
                    }
                    else
                    {
                        if (a == 1)
                        {
                            elevadorParado[5] = "B";
                        }
                        else
                        {
                            if (a == 2)
                            {
                                elevadorParado[5] = "C";
                            }
                            else
                            {
                                if (a == 3)
                                {
                                    elevadorParado[5] = "D";
                                }
                                else
                                {
                                    elevadorParado[5] = "E";
                                }
                            }
                        }
                    }
                }
            }
            if (elevadorParado[5]=="A")
            {
                for (int b = 0; b < control.Count; b++)
                {
                    if (control[b].elevador == "A")
                    {
                        if (control[b].turno == "M")
                        {
                            turnoContador[0]++;
                        }
                        if (control[b].turno == "V")
                        {
                            turnoContador[1]++;
                        }
                        if (control[b].turno == "N")
                        {
                            turnoContador[2]++;
                        }
                    }
                    
                }
            }
            if (elevadorParado[5] == "B")
            {
                for (int b = 0; b < control.Count; b++)
                {
                    if (control[b].elevador == "B")
                    {
                        if (control[b].turno == "M")
                        {
                            turnoContador[0]++;
                        }
                        if (control[b].turno == "V")
                        {
                            turnoContador[1]++;
                        }
                        if (control[b].turno == "N")
                        {
                            turnoContador[2]++;
                        }
                    }

                }
            }
            if (elevadorParado[5] == "C")
            {
                for (int b = 0; b < control.Count; b++)
                {
                    if (control[b].elevador == "C")
                    {
                        if (control[b].turno == "M")
                        {
                            turnoContador[0]++;
                        }
                        if (control[b].turno == "V")
                        {
                            turnoContador[1]++;
                        }
                        if (control[b].turno == "N")
                        {
                            turnoContador[2]++;
                        }
                    }

                }
            }
            if (elevadorParado[5] == "D")
            {
                for (int b = 0; b < control.Count; b++)
                {
                    if (control[b].elevador == "D")
                    {
                        if (control[b].turno == "M")
                        {
                            turnoContador[0]++;
                        }
                        if (control[b].turno == "V")
                        {
                            turnoContador[1]++;
                        }
                        if (control[b].turno == "N")
                        {
                            turnoContador[2]++;
                        }
                    }

                }
            }
            if (elevadorParado[5] == "E")
            {
                for (int b = 0; b < control.Count; b++)
                {
                    if (control[b].elevador == "E")
                    {
                        if (control[b].turno == "M")
                        {
                            turnoContador[0]++;
                        }
                        if (control[b].turno == "V")
                        {
                            turnoContador[1]++;
                        }
                        if (control[b].turno == "N")
                        {
                            turnoContador[2]++;
                        }
                    }

                }
            }
            for (int c = 0; c < 3; c++)
            {
                if (turnoContador[c]>turnoMaior)
                {
                    turnoMaior = turnoContador[c];
                    turnoMaisU = c;
                }
            }
            switch (turnoMaisU)
            {
                case 0:
                    turnoAtual = "M";
                    break;
                case 1:
                    turnoAtual = "V";
                    break;
                case 2:
                    turnoAtual = "N";
                    break;
            }

            Console.WriteLine("O Elevador mais utilizado é o " + elevadorParado[5] + " e o turno mais utilizado nesse elevador é " + turnoAtual + " com " + turnoMaior + " vezes.");

            Console.ReadKey();
            throw new NotImplementedException();
        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
          
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Input.json");
            var control = JsonConvert.DeserializeObject<List<Controle>>(json);
            int[] turnoContador =new int[3];
            int turnoMaior = 0;
            int turnoMaisU = 0;
            string turnoAtual = "0";

            for (int i = 0; i < control.Count; i++)
            {
                if (control[i].turno == "M")
                {
                    turnoContador[0]++;
                }
                if (control[i].turno == "V")
                {
                    turnoContador[1]++;
                }
                if (control[i].turno == "N")
                {
                    turnoContador[2]++;
                }
            }
            for (int c = 0; c < 3; c++)
            {
                if (turnoContador[c] > turnoMaior)
                {
                    turnoMaior = turnoContador[c];
                    turnoMaisU = c;
                }
            }
            switch (turnoMaisU)
            {
                case 0:
                    turnoAtual = "M";
                    break;
                case 1:
                    turnoAtual = "V";
                    break;
                case 2:
                    turnoAtual = "N";
                    break;
            }
            Console.WriteLine("Turno mais ultilizado é o " + turnoAtual + " ultilizando os elevadores " + turnoMaior + " vezes.");

            throw new NotImplementedException();
        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Input.json");
            var control = JsonConvert.DeserializeObject<List<Controle>>(json);
            List<string> elevadorParado = new List<string>();
            int[] elevadorContador = new int[5];
            int elevadorMenor = control.Count;
            int[] turnoContador = new int[3];
            int turnoMenor = control.Count;
            int turnoMenosU = 0;
            string turnoAtual = "0";

            for (int i = 0; i < control.Count; i++)
            {
                elevadorParado.Add(control[i].elevador);
            }

            for (int i = 0; i < control.Count; i++)
            {
                switch (elevadorParado[i])
                {
                    case "A":
                        elevadorContador[0]++;
                        break;
                    case "B":
                        elevadorContador[1]++;
                        break;
                    case "C":
                        elevadorContador[2]++;
                        break;
                    case "D":
                        elevadorContador[3]++;
                        break;
                    case "E":
                        elevadorContador[4]++;
                        break;

                }

            }
            for (int a = 0; a < 5; a++)
            {
                if (elevadorContador[a] < elevadorMenor)
                {
                    elevadorMenor = elevadorContador[a];
                    if (a == 0)
                    {
                        elevadorParado[5] = "A";
                    }
                    else
                    {
                        if (a == 1)
                        {
                            elevadorParado[5] = "B";
                        }
                        else
                        {
                            if (a == 2)
                            {
                                elevadorParado[5] = "C";
                            }
                            else
                            {
                                if (a == 3)
                                {
                                    elevadorParado[5] = "D";
                                }
                                else
                                {
                                    elevadorParado[5] = "E";
                                }
                            }
                        }
                    }
                }

            }
            if (elevadorParado[5] == "A")
            {
                for (int b = 0; b < control.Count; b++)
                {
                    if (control[b].elevador == "A")
                    {
                        if (control[b].turno == "M")
                        {
                            turnoContador[0]++;
                        }
                        if (control[b].turno == "V")
                        {
                            turnoContador[1]++;
                        }
                        if (control[b].turno == "N")
                        {
                            turnoContador[2]++;
                        }
                    }

                }
            }
            if (elevadorParado[5] == "B")
            {
                for (int b = 0; b < control.Count; b++)
                {
                    if (control[b].elevador == "B")
                    {
                        if (control[b].turno == "M")
                        {
                            turnoContador[0]++;
                        }
                        if (control[b].turno == "V")
                        {
                            turnoContador[1]++;
                        }
                        if (control[b].turno == "N")
                        {
                            turnoContador[2]++;
                        }
                    }

                }
            }
            if (elevadorParado[5] == "C")
            {
                for (int b = 0; b < control.Count; b++)
                {
                    if (control[b].elevador == "C")
                    {
                        if (control[b].turno == "M")
                        {
                            turnoContador[0]++;
                        }
                        if (control[b].turno == "V")
                        {
                            turnoContador[1]++;
                        }
                        if (control[b].turno == "N")
                        {
                            turnoContador[2]++;
                        }
                    }

                }
            }
            if (elevadorParado[5] == "D")
            {
                for (int b = 0; b < control.Count; b++)
                {
                    if (control[b].elevador == "D")
                    {
                        if (control[b].turno == "M")
                        {
                            turnoContador[0]++;
                        }
                        if (control[b].turno == "V")
                        {
                            turnoContador[1]++;
                        }
                        if (control[b].turno == "N")
                        {
                            turnoContador[2]++;
                        }
                    }

                }
            }
            if (elevadorParado[5] == "E")
            {
                for (int b = 0; b < control.Count; b++)
                {
                    if (control[b].elevador == "E")
                    {
                        if (control[b].turno == "M")
                        {
                            turnoContador[0]++;
                        }
                        if (control[b].turno == "V")
                        {
                            turnoContador[1]++;
                        }
                        if (control[b].turno == "N")
                        {
                            turnoContador[2]++;
                        }
                    }

                }
            }
            for (int c = 0; c < 3; c++)
            {
                if (turnoContador[c] < turnoMenor)
                {
                    turnoMenor = turnoContador[c];
                    turnoMenosU = c;
                }
            }
            switch (turnoMenosU)
            {
                case 0:
                    turnoAtual = "M";
                    break;
                case 1:
                    turnoAtual = "V";
                    break;
                case 2:
                    turnoAtual = "N";
                    break;
            }
            Console.WriteLine("O Elevador menos utilizado é o " + elevadorParado[5] + " e o turno menos utilizado nesse elevador é " + turnoAtual + " com " + turnoMenor + " vezes.");

            Console.ReadKey();
            throw new NotImplementedException();
        }
    }


}
