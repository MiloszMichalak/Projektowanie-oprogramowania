namespace Kompozyt.classes;

public class Composite : Komponent
{
    public List<Komponent> Components = new();
    
    public void Operation() {}
    public void Add() {}
    public void Remove() {}
    public void GetChild() {}
}