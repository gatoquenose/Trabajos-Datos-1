using System;
using System.Text;

class Node
{
    public int value;
    public Node? next;
    public Node? prev;

    public Node(int value)
    {
        this.value = value;
        this.next = null;
        this.prev = null;
    }
}

public class ListaDoblementeCircular
{
    private Node? head;
    private Node? tail;
    private int size;

    public ListaDoblementeCircular()
    {
        head = null;
        tail = null;
        size = 0;
    }

    public void Insertaralprincipio(int value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
            head.next = head;
            head.prev = head;
        }
        else
        {
            newNode.next = head;
            newNode.prev = tail;
            tail!.next = newNode;
            head!.prev = newNode;
            head = newNode;
        }
        size++;
    }

    public void Insertaralfinal(int value)
    {
        Node newNode = new Node(value);

        if (tail == null)
        {
            head = newNode;
            tail = newNode;
            head.next = head;
            head.prev = head;
        }
        else
        {
            newNode.next = head;
            newNode.prev = tail;
            tail!.next = newNode;
            head!.prev = newNode;
            tail = newNode;
        }
        size++;
    }

    public void InserAt(int value, int index)
    {
        if (index < 0 || index > size)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Índice fuera de rango.");
        }

        if (index == 0)
        {
            Insertaralprincipio(value);
            return;
        }

        if (index == size)
        {
            Insertaralfinal(value);
            return;
        }

        Node newNode = new Node(value);
        Node? current = head;

        for (int i = 0; i < index - 1; i++)
        {
            current = current!.next;
        }

        newNode.next = current!.next;
        newNode.prev = current;
        current.next!.prev = newNode;
        current.next = newNode;

        size++;
    }

    public void EliminarPrimero()
    {
        if (head == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        if (head == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            head = head.next;
            head!.prev = tail;
            tail!.next = head;
        }
        size--;
    }

    public void EliminarUltimo()
    {
        if (tail == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        if (head == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            tail = tail.prev;
            tail!.next = head;
            head!.prev = tail;
        }
        size--;
    }

    public void EliminarEn(int index)
    {
        if (index < 0 || index >= size)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Índice fuera de rango.");
        }

        if (index == 0)
        {
            EliminarPrimero();
            return;
        }

        if (index == size - 1)
        {
            EliminarUltimo();
            return;
        }

        Node? current = head;

        for (int i = 0; i < index; i++)
        {
            current = current!.next;
        }

        current!.prev!.next = current.next;
        current.next!.prev = current.prev;

        size--;
    }

    public int ObtenerTamaño()
    {
        return size;
    }

    public override string ToString()
    {
        if (head == null)
        {
            return "La lista está vacía.";
        }

        StringBuilder sb = new StringBuilder();
        Node? actual = head;
        do
        {
            sb.Append(actual!.value);
            actual = actual.next;
            if (actual != head)
            {
                sb.Append(", ");
            }
        } while (actual != head);

        return sb.ToString();
    }

    public void ImprimirLista()
    {
        Console.WriteLine(ToString());
    }

    public void EjecutarOperaciones()
    {
        Insertaralprincipio(30);
        Insertaralprincipio(30);
        Insertaralprincipio(20);
        Insertaralprincipio(10);

        Insertaralfinal(40);
        Insertaralfinal(50);

    }
}