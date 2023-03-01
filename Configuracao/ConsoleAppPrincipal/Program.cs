using BLL;
using DAL;
using Models;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppPrincipal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int re = 0;
            Console.WriteLine("Opcões:Usuário \n\n[1]Inserir \n[2]Buscar um usuário \n[3]Buscar Todos \n[4]Alterar \n[5]Excluir \n\n\n Opcões:Grupo de Usuários \n\n[6]Inserir \n[7]Buscar um Grupo \n[8]Buscar Todos os Grupos \n[9]Alterar \n[10]Excluir \n\nOpcões:Descrição  \n\n[11]Inserir \n[12]Buscar uma Descrição \n[13]Buscar Todas as Descrições \n[14]Alterar \n[15]Excluir \n\nEscolha uma opção: ");
            re = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (re)
            {
                case 1:
                    InserirUsuario();
                    break;
                case 2:
                    BuscarUsuario();
                    break;
                case 3:
                    BuscarTodosUsuario();
                    break;
                case 4:
                    AlterarUsuario();
                    break;
                case 5: 
                    ExcluirUsuario();
                    break;
                case 6:
                    InserirGrupoUsuario();
                        break;
                case 7:
                    BuscarGrupoUsuario();
                    break;
                case 8:
                    BuscarTodosGrupoUsuario();
                    break;
                case 9:
                    AlterarGrupoUsuario();
                    break;
                case 10:
                    ExcluirGrupoUsuario();
                    break;
                case 11:
                    InserirPermissao();
                    break;
                case 12:
                    BuscarPermissao();
                    break;
                case 13:
                    BuscarTodosPermissao();
                    break;
                case 14:
                    AlterarPermissao();
                    break;
                case 15:
                    ExcluirPermissao();
                    break;


            }
        }

        //Usuario ___________________________________________________________________________________________________________________________________

        public static void InserirUsuario() //Finalizado
        {
            int resp;
            try
            {


                Console.WriteLine("Deseja fazer um Cadastro: [1]Sim [2]Não ");
                resp = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                while (resp == 1)
                {


                    UsuarioBLL usuarioBLL = new UsuarioBLL();
                    Usuario usuario = new Usuario();

                    Console.WriteLine("Informe o seu nome completo: ");
                    usuario.Nome = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("-------- O nome de usuário não deve conter espaço em branco --------\n\n");
                    Console.WriteLine("Informe o seu nome de Usuario: ");
                    usuario.NomeUsuario = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("O usuário estará ativo (S) ou (N) ");
                    usuario.Ativo = Console.ReadLine().ToUpper() == "S";
                    Console.Clear();
                    Console.WriteLine("Informe o seu Email: ");
                    usuario.Email = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Informe o seu CPF: ");
                    usuario.CPF = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("----- Sua senha deve conter no mínimo 7 digitos e no máximo 11 -----\n\n");
                    Console.WriteLine("Crie uma senha:");
                    usuario.Senha = Console.ReadLine();//Entre 7 e 11 dígitos
                    Console.Clear();
                    usuarioBLL.Inserir(usuario);
                    Console.Clear();

                    Console.WriteLine("Deseja fazer outro Cadastro: [1]Sim [2]Não ");
                    resp = Convert.ToInt32(Console.ReadLine());

                }
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public static void BuscarUsuario() //Finalizado
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();

            Console.WriteLine("Informe o nome que deseja buscar: ");
            usuario.NomeUsuario = Console.ReadLine();
            usuario = usuarioBLL.BuscarPorNomeUsuario(usuario.NomeUsuario);
            Console.WriteLine("Id: " + usuario.Id);
            Console.WriteLine("Nome: " + usuario.Nome);
            Console.WriteLine("NomeUsuario: " + usuario.NomeUsuario);
            Console.WriteLine("CPF: " + usuario.CPF);
            Console.WriteLine("Email: " + usuario.Email);
            Console.WriteLine("Ativo: " + usuario.Ativo);

        }
        public static void BuscarTodosUsuario() //Finalizado 
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            List<Usuario> usuarios = usuarioBLL.BuscarTodos();
            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine("Id: " + usuario.Id);
                Console.WriteLine("Nome: " + usuario.Nome);
                Console.WriteLine("NomeUsuario: " + usuario.NomeUsuario);
                Console.WriteLine("CPF: " + usuario.CPF);
                Console.WriteLine("Email: " + usuario.Email);
                Console.WriteLine("Ativo: " + usuario.Ativo);

                
            }
        }
        public static void AlterarUsuario()
        {

        }
        public static void ExcluirUsuario()
        {

        }


       // Grupo Usuario _____________________________________________________________________________________________________________________________

        public static void InserirGrupoUsuario() //Finalizar 
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            GrupoUsuario grupoUsuario = new GrupoUsuario();

            Console.WriteLine("Insira um novo Grupo de Usuários: ");
            grupoUsuario.NomeGrupo = Console.ReadLine();
            grupoUsuarioBLL.Inserir(grupoUsuario);
        }
        public static void BuscarGrupoUsuario()
        {

        }
        public static void BuscarTodosGrupoUsuario() //Finalizar
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            List<GrupoUsuario> grupoUsuarios = grupoUsuarioBLL.BuscarTodos();
            foreach (GrupoUsuario grupoUsuario in grupoUsuarios)
            {
                Console.WriteLine("Id: " + grupoUsuario.Id);
                Console.WriteLine("Descrição: " + grupoUsuario.NomeGrupo);
            }

        }
        public static void AlterarGrupoUsuario() //Finalizar 
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            GrupoUsuario grupoUsuario = new GrupoUsuario();

            Console.WriteLine("Informe o Id que deseja alterar: ");
            grupoUsuario.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Crie um novo grupo de Usuários: ");
            grupoUsuario.NomeGrupo = Console.ReadLine();
            grupoUsuarioBLL.Alterar(grupoUsuario);
        }
        public static void ExcluirGrupoUsuario() //Finalizar 
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            GrupoUsuario grupoUsuario = new GrupoUsuario();

            Console.WriteLine("Informe o Id que deseja excluir: ");
            grupoUsuario.Id = Convert.ToInt32(Console.ReadLine());
            grupoUsuarioBLL.Excluir(grupoUsuario);

        }

        // Descrição _______________________________________________________________________________________________________________________________

        public static void InserirPermissao() //Finalizado
        {
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            Permissao permissao = new Permissao();

            Console.WriteLine("Crie uma descrição ");
            permissao.Descricao = Console.ReadLine();
            permissaoBLL.Inserir(permissao);
        }
        public static void BuscarPermissao()
        {

        }
        public static void BuscarTodosPermissao() //Finalizado
        {
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            List<Permissao>permissoes = permissaoBLL.BuscarTodos();
            foreach (Permissao permissao in permissoes)
            {
                Console.WriteLine("Id: "+ permissao.Id);
                Console.WriteLine("Descrição: " + permissao.Descricao);
            }
        }
        public static void AlterarPermissao() //Finalizado 
        {
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            Permissao permissao = new Permissao();

            Console.WriteLine("Informe o Id que deseja alterar: : ");
            permissao.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Crie uma nova Descrição: ");
            permissao.Descricao = Console.ReadLine();
            permissaoBLL.Alterar(permissao);

        }
        public static void ExcluirPermissao() //Finalizado
        {
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            Permissao permissao = new Permissao();

            Console.WriteLine("Informe o Id que deseja excluir: ");
            permissao.Id = Convert.ToInt32(Console.ReadLine());
            permissaoBLL.Excluir(permissao);
        }


    }


}


/*                    Console.Clear();
                    Console.WriteLine("Deseja adicionar uma descrição: [1]Sim [2]Não: ");
                    int resp1 = Convert.ToInt32(Console.ReadLine());

                    if (resp1 == 1)
                    {
                        PermissaoBLL permissaoBLL = new PermissaoBLL();
                        Permissao permissao = new Permissao();

                        Console.WriteLine("Crie uma descrição ");
                        permissao.Descricao = Console.ReadLine();
                        permissaoBLL.Inserir(permissao);



                    }*/

/* 
              }
              Console.Clear();
              Console.WriteLine("Deseja recriar a sua descrição: [1]Sim [2]Não: ");
              int resp2 = Convert.ToInt32(Console.ReadLine());

              if (resp2 == 1)
              {
                  PermissaoBLL permissaoBLL = new PermissaoBLL();
                  Permissao permissao = new Permissao();

                  Console.WriteLine("Informe o Id que deseja alterar: : ");
                  permissao.Id = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Crie uma nova Descrição: ");
                  permissao.Descricao = Console.ReadLine();
                  permissaoBLL.Alterar(permissao);

              }
              Console.Clear();

              Console.WriteLine("Deseja fazer outro cadastro: [1]Sim [2]Não ");
              resp = Convert.ToInt32(Console.ReadLine());*/




