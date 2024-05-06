// See https://aka.ms/new-console-template for more information
using Listas;

Console.WriteLine("Hello, listas!");

List<Contact> list = new();

list.Add(new("Tony", "014"));
list.Add(new("Felipe", "123"));

foreach (Contact item in list) //
{
    Console.WriteLine(item.ToString());
}
Console.ReadLine();
foreach (Contact item in list) //
{
    Console.WriteLine(item.ToString());
}
Console.ReadLine();
list.Add(new("Odair", "567"));
foreach (Contact item in list) //
{
    Console.WriteLine(item.ToString());
}
Console.ReadLine();

list.Remove(list.Find(x => x.getName() == "Tony"));



// faça um programa que crie uma agenda de telefone funcional (adiciono, mostrar ou agenda toda,
// ou contato especifico), editar, remover) (nome completo, telefones, endereço, e-mail)


#region manual
//contactList l1 = new contactList();

//Contact contact1 = new Contact("Bernardo", "123");
//l1.Add(contact1);

//Contact contact2 = new("Ana", "321");
//l1.Add(contact2);

//Contact contact3 = new("Caue", "456");
//l1.Add(contact3);

//l1.Add(new Contact("Bruna", "987"));

//l1.ShowAll();

////l1.Remove("Ana");
////l1.ShowAll();

////l1.Remove("Bruna");
////l1.ShowAll();

//Console.WriteLine("\nDigite o nome a ser removido: (NOMES CITADOS ACIMA, ESCREVA CORRETAMENTE) : ");
//string nameToRemove = Console.ReadLine();
//l1.Remove(nameToRemove);

//l1.ShowAll();

//Console.WriteLine("\nAperta qualquer tecla para encerrar o programa!");
//Console.ReadKey();
#endregion