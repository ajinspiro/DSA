using DSA;
using System.Collections;

var t1 = new Timing();
t1.startTime();
var col1 = new Collecxion();
for (int i = 0; i < 1_000_000; i++)
{
    col1.Add(i);
}
t1.StopTime();
Console.WriteLine("Collecxion " + t1.Result());

var t2 = new Timing();
t2.startTime();
var col2 = new ArrayList();
for (int i = 0; i < 1_000_0000; i++)
{
    col2.Add(i);
}
t2.StopTime();
Console.WriteLine("ArrayList " + t2.Result());
