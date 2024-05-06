using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class contactList
    {
        Contact? head;
        Contact? tail;

        public contactList()
        {
            this.head = null;
            this.tail = null;
        }

        public void Add(Contact contact)
        {
            // this.head = contact;
            if (IsEmpty())
            {
                this.head = contact;
                this.tail = contact;
            }
            else
            {
                int compare = string.Compare(contact.getName(), head.getName(), comparisonType: StringComparison.OrdinalIgnoreCase);
                if (compare <= 0)
                {
                    Contact aux = head;
                    head = contact;
                    head.setNext(aux);
                }
                else
                {
                    Contact aux = head;
                    Contact prev = head;
                    do
                    {
                        compare = string.Compare(contact.getName(), aux.getName());
                        if (compare > 0)
                        {
                            prev = aux;
                            aux = aux.getNext();
                        }
                        //else
                        //{
                        //    prev.setNext(contact);
                        //    contact.setNext(aux);
                        //}
                    } while (aux != null && compare > 0);
                    //do
                    //{

                    //while (aux != null && compare > 0)
                    //{
                    //    compare = string.Compare(contact.getName(), aux.getName());
                    //    if (compare > 0)
                    //    {
                    //        prev = aux;
                    //        aux = aux.getNext();
                    //    }
                    //    //else
                    //    //{

                    //    //}
                    //}                        
                    prev.setNext(contact);
                    contact.setNext(aux);
                    if (aux == null)
                    {
                        tail = contact;
                    }
                    ////} while (compare > 0);
                }
            }
        }
        bool IsEmpty()
        {
            if (this.head == null && this.tail == null)
                return true;
            else
                return false;
        }
        public void Remove(string name)
        {
            //if (IsEmpty())
            //{
            //    return; // Nada para remover se a lista estiver vazia
            //}
            //if (string.Compare(head.getName(), name, comparisonType: StringComparison.OrdinalIgnoreCase) == 0)
            //{
            //    if (head == tail) 
            //    {
            //        head = null;
            //        tail = null;
            //    }
            //    else 
            //    {
            //        head = head.getNext();
            //    }
            //    return;
            //}
            //Contact atual = head;
            //Contact previous = null;
            //while (atual != null)
            //{
            //    if (string.Compare(atual.getName(), name, comparisonType: StringComparison.OrdinalIgnoreCase) == 0)
            //    {
            //        if (previous == null) 
            //        {
            //            head = atual.getNext();
            //        }
            //        else
            //        {
            //            previous.setNext(atual.getNext());
            //        }
            //        if (atual == tail)
            //        {
            //            tail = previous;
            //        }
            //        return;
            //    }
            //    previous = atual;
            //    atual = atual.getNext();
            //}
            // Console.WriteLine("Nao existe o contato na lista");
            //}
            if (!IsEmpty())
            {
                if (name == this.head.getName())
                {
                    if (head == tail)
                        tail = head = null;
                    else
                    {
                        head = head.getNext();
                    }
                }
                else
                {
                    Contact aux = head;
                    Contact prev = head;
                    bool compare;
                    do
                    {
                        compare = name.Equals(aux.getName());
                        if (!compare)
                        {
                            prev = aux;
                            aux = aux.getNext();
                        }
                        else
                        {
                            prev.setNext(aux.getNext());
                            if (prev.getNext() == null)
                                tail = prev;
                        }
                    } while (compare == false && aux != null);
                    if (aux == null)
                    {
                        Console.WriteLine("\nNao existe o contato na lista");
                    }
                }
            }
        }

        public void ShowAll()
        {
            Contact aux = head;
            do
            {
                Console.WriteLine(aux.ToString());
                aux = aux.getNext();
            } while (aux != null);
        }

    }
}
