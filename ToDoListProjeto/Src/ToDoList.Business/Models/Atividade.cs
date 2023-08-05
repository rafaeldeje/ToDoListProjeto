namespace ToDoList.Business.Models;

public class Atividade : Entity
{
    public string Descricao { get; set; }
    public bool Feito { get; set; }
    public DateTime DataDeFazer { get; set; }
    public DateTime DataDeTermino { get; set; }
    public Guid PessoaId { get; set; }

    /*Essa propriedade define o que EntityFramework vai ler e entender que a minha class
     Pessoa.cs com o nome-criado Pessoa, possui um relacionamento com a minha class Atividade.cs*/
    public Pessoa Pessoa { get; set; }
}