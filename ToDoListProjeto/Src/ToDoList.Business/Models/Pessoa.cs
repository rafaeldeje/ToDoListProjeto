namespace ToDoList.Business.Models;

public class Pessoa : Entity
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Genero { get; set; }
    
    /*A tipagem IEnumerable vai defirnir uma lista de Atividades, para uma Pessoa.
     Assim uma Pessoa tem N atividades mas Atividade terá uma Pessoa Somente. 
     */
    public IEnumerable<Atividade> Atividades { get; set; }
}