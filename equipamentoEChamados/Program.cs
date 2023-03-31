using System.Collections;

namespace equipamentoEChamados
{
    internal class Program
    {
        static string nomeEquipamento = "", precoEquipamento = "", nSerieEquipamento = "", dataEquipamento = "", fabricanteEquipamento = "";
        static string tituloChamada = "", descricaoChamada = "", nEquipamentoChamada = "", dataAberturaChamada = "";
        static Boolean achouEquipamento = false, achouEquipamentoExcluir = false, achouEquipamentoChamado = false, achouEquipamentoExcluirChamado = false;
        static void Main(string[] args)
        {
            ArrayList equipamento = new ArrayList();
            ArrayList chamado = new ArrayList();

            int respostaGeral = menuGeral();
            while (respostaGeral != 3)
            {
                if (respostaGeral == 1)
                {
                    Console.Clear();
                    int respostaEquipamento = menuEquipamentos();
                    while (respostaEquipamento != 5)
                    {
                        Console.WriteLine();
                        switch (respostaEquipamento)
                        {
                            case 1:
                                informacoesEquipamento();
                                Console.WriteLine();
                                equipamento.Add(nomeEquipamento + " " + precoEquipamento + " " + nSerieEquipamento + " " + dataEquipamento + " " + fabricanteEquipamento);
                                Console.Clear();
                                break;
                            case 2:
                                if (equipamento.Count == 0)
                                    Console.WriteLine("Nenhum equipamento cadastrado!");
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("---------------------------------------------");
                                    Console.WriteLine(" Nome | Preço | N° Série | Data | Fabricante");
                                    Console.WriteLine("----------------------------------------------");
                                    for (int i = 0; i < equipamento.Count; i++)
                                    {
                                        Console.WriteLine(equipamento[i]);
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case 3:
                                Console.WriteLine("Digite o nome do equipamento a ser mudado: ");
                                nomeEquipamento = Console.ReadLine();
                                for (int i = 0; i < equipamento.Count; i++)
                                {
                                    string[] info = equipamento[i].ToString().Split(" ");
                                    if (nomeEquipamento.Equals(info[0]))
                                    {
                                        achouEquipamento = true;
                                        Console.WriteLine();
                                        Console.WriteLine("Digite agora as novas informações do produto: ");
                                        informacoesEquipamento();
                                        equipamento[i] = (nomeEquipamento + ";" + precoEquipamento + ";" + nSerieEquipamento + ";" + dataEquipamento + ";" + fabricanteEquipamento);
                                        Console.WriteLine();
                                        break;
                                    }
                                }
                                if (achouEquipamento == false)
                                {
                                    Console.WriteLine("Nome não achado nos dados.");
                                    Console.WriteLine();
                                }
                                Console.Clear();
                                break;
                            case 4:
                                Console.WriteLine();
                                Console.Write("Digite o nome do equipamento à ser excluido: ");
                                string nomeExcluir = Console.ReadLine();
                                for (int i = 0; i < equipamento.Count; i++)
                                {
                                    string[] info = equipamento[i].ToString().Split(";");
                                    if (nomeExcluir.Equals(info[0]))
                                    {
                                        achouEquipamentoExcluir = true;
                                        Console.WriteLine();
                                        Console.WriteLine("Tem certeza que deseja excluir? \n (1)Sim (2)Nao");
                                        int rExcluir = int.Parse(Console.ReadLine());
                                        if (rExcluir == 1)
                                        {
                                            equipamento.RemoveAt(i);
                                            Console.WriteLine("Equipamento excluido com sucesso!");
                                        }
                                        else
                                            Console.WriteLine("Operação Cancelada");
                                        Console.WriteLine();
                                        break;
                                    }
                                }
                                if (achouEquipamentoExcluir == false)
                                {
                                    Console.WriteLine("Nome não achado nos dados.");
                                    Console.WriteLine();
                                }
                                break;
                        }
                        respostaEquipamento = menuEquipamentos();
                    }
                }
                if (respostaGeral == 2)
                {
                    Console.Clear();
                    int respostaChamada = menuChamados();
                    while (respostaChamada != 5)
                    {
                        Console.WriteLine();
                        switch (respostaChamada)
                        {
                            case 1:
                                informacoesChamado();
                                Console.WriteLine();
                                chamado.Add(tituloChamada + " " + descricaoChamada + " " + nEquipamentoChamada + " " + dataAberturaChamada);
                                Console.Clear();
                                break;
                            case 2:
                                if (chamado.Count == 0)
                                    Console.WriteLine("Nenhum chamado cadastrado!");
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("---------------------------------------------");
                                    Console.WriteLine(" Titulo | Descrição | Equipamento | Data");
                                    Console.WriteLine("----------------------------------------------");
                                    for (int i = 0; i < chamado.Count; i++)
                                    {
                                        Console.WriteLine(chamado[i]);
                                    }
                                }
                                Console.WriteLine();
                                break;

                            case 3:
                                Console.WriteLine("Digite o nome do equipamento relacionado: ");
                                nEquipamentoChamada = Console.ReadLine();
                                for (int i = 0; i < chamado.Count; i++)
                                {
                                    string[] info = chamado[i].ToString().Split(";");
                                    if (nEquipamentoChamada.Equals(info[2]))
                                    {

                                        achouEquipamentoChamado = true;
                                        Console.WriteLine();
                                        Console.WriteLine("Digite agora as novas informações do chamado: ");
                                        informacoesChamado();
                                        chamado[i] = (tituloChamada + ";" + descricaoChamada + ";" + nEquipamentoChamada + ";" + dataAberturaChamada);
                                        Console.WriteLine();
                                        break;
                                    }
                                }
                                if (achouEquipamentoChamado == false)
                                {
                                    Console.WriteLine("Nome não achado nos dados.");
                                    Console.WriteLine();
                                }
                                Console.Clear();
                                break;

                            case 4:
                                Console.WriteLine();
                                Console.Write("Digite o nome do equipamento à ser excluido dos chamados : ");
                                string nomeExcluirChamados = Console.ReadLine();
                                for (int i = 0; i < chamado.Count; i++)
                                {
                                    string[] info = chamado[i].ToString().Split(" ");
                                    if (nomeExcluirChamados.Equals(info[0]))
                                    {
                                        achouEquipamentoExcluirChamado = true;
                                        Console.WriteLine();
                                        Console.WriteLine("Tem certeza que deseja excluir? \n (1)Sim (2)Nao");
                                        int rExcluir = int.Parse(Console.ReadLine());
                                        if (rExcluir == 1)
                                        {
                                            chamado.RemoveAt(i);
                                            Console.WriteLine("Chamado excluido com sucesso!");
                                        }
                                        else
                                            Console.WriteLine("Operação Cancelada");
                                        Console.WriteLine();
                                        break;
                                    }
                                }
                                if (achouEquipamentoExcluirChamado == false)
                                {
                                    Console.WriteLine("Nome não achado nos dados.");
                                    Console.WriteLine();
                                }
                                break;
                        }

                        respostaChamada = menuChamados();
                    }
                }
                Console.Clear();
                respostaGeral = menuGeral();
            }
        }

        static int menuGeral()
        {
            Console.WriteLine("O que você deseja fazer: \n (1)Menu Equipamentos (2)Menu Chamados (3)Sair");
            return int.Parse(Console.ReadLine());
        }
        static int menuEquipamentos()
        {
            Console.WriteLine("O que você deseja fazer: \n (1)Registrar Equipamento (2)Visualizar Equipamentos (3)Editar Equipamento (4)Excluir Equipamento (5)Sair");
            return int.Parse(Console.ReadLine());
        }
        static int menuChamados()
        {
            Console.WriteLine("O que você deseja fazer: \n (1)Registrar Chamados (2)Visualizar Chamados (3)Editar Chamados (4)Excluir Chamados (5)Sair");
            return int.Parse(Console.ReadLine());
        }
        static void informacoesEquipamento()
        {
            Console.Write("Digite o nome: ");
            nomeEquipamento = Console.ReadLine();
            while (nomeEquipamento.Length - 1 <= 6)
            {
                Console.Write("Digite o nome(Deve ter mais de 6 caracteres): ");
                nomeEquipamento = Console.ReadLine();
            }
            Console.Write("Digite o preço: ");
            precoEquipamento = Console.ReadLine();
            Console.Write("Digite o número de série: ");
            nSerieEquipamento = Console.ReadLine();
            Console.Write("Digite a data de fabricação: ");
            dataEquipamento = Console.ReadLine();
            Console.Write("Digite a empresa fabricante: ");
            fabricanteEquipamento = Console.ReadLine();
        }
        static void informacoesChamado()
        {
            Console.Write("Digite o título: ");
            tituloChamada = Console.ReadLine();
            Console.Write("Digite a descrição: ");
            descricaoChamada = Console.ReadLine();
            Console.Write("Digite o equipamento relacionado: ");
            nEquipamentoChamada = Console.ReadLine();
            Console.Write("Digite a data de abertura do chamado: ");
            dataAberturaChamada = Console.ReadLine();

        }

    }