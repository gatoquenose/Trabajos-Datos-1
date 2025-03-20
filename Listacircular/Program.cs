using System;
using System.Text;

class Node
{
    public int value;
    public Node? next;

    public Node(int value)
    {
        this.value = value;
        this.next = null;
    }
}

public class ListaCircular
{
    private Node? head;
    private Node? tail;
    private int size;

    public ListaCircular()
    {
        head = null;
        tail = null;
        size = 0;
    }

    public void InsertarAlInicio(int value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
            head.next = head;
        }
        else
        {
            newNode.next = head;
            tail!.next = newNode;
            head = newNode;
        }
        size++;
    }

    public void InsertarAlFinal(int value)
    {
        Node newNode = new Node(value);

        if (tail == null)
        {
            head = newNode;
            tail = newNode;
            head.next = head;
        }
        else
        {
            newNode.next = head;
            tail!.next = newNode;
            tail = newNode;
        }
        size++;
    }

    public void InsertAt(int value, int index)
    {
        if (index < 0 || index > size)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Índice fuera de rango.");
        }

        if (index == 0)
        {
            InsertarAlInicio(value);
            return;
        }

        if (index == size)
        {
            InsertarAlFinal(value);
            return;
        }

        Node newNode = new Node(value);
        Node? current = head;

        for (int i = 0; i < index - 1; i++)
        {
            current = current!.next;
        }

        newNode.next = current!.next;
        current.next = newNode;

        size++;
    }

    public void EliminarAlInicio()
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
            tail!.next = head;
        }
        size--;
    }

    public void EliminarAlFinal()
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
            Node? current = head;
            while (current!.next != tail)
            {
                current = current.next;
            }
            current.next = head;
            tail = current;
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
            EliminarAlInicio();
            return;
        }

        if (index == size - 1)
        {
            EliminarAlFinal();
            return;
        }

        Node? current = head;

        for (int i = 0; i < index - 1; i++)
        {
            current = current!.next;
        }

        current!.next = current.next!.next;

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
}