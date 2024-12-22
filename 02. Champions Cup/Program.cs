using System.Drawing;
using System;
using System.Text;

int n = int.Parse(Console.ReadLine()!);
StringBuilder sb = new();
int cnt = 0;


// top half full cup - N/2 rows
// top half partial cup - N/2 + 1 rows
// top of body transition line - 1 row
// top of body N / 2 rows
// logo
// bottom of body N / 2 + 1 rows

for (int i = 0; i < n; i += 2)
{
    sb.Append(new String('.', n + i / 2));
    sb.Append(new String('#', n * 3 - i));
    sb.Append(new String('.', n + i / 2));
    sb.AppendLine();
    cnt++;
}

for (int i = 0; i < n * 2; i += 2)
{
    cnt++;
    sb.Append(new String('.', n + n / 2 + i / 2));
    sb.Append(new String('#', 1));
    sb.Append(new String('.', n * 2 - 2 - i));
    sb.Append(new String('#', 1));
    sb.Append(new String('.', n + n / 2 + i / 2));
    sb.AppendLine();

    if (n * 2 - 2 - i == n - 2)
    {
        cnt++;
        sb.Append(new String('.', n + n / 2 + i / 2));
        sb.Append(new String('#', 1));
        sb.Append(new String('#', n * 2 - 2 - i));
        sb.Append(new String('#', 1));
        sb.Append(new String('.', n + n / 2 + i / 2));
        sb.AppendLine();

        break;
    }
}

for (int i = 1; i <= cnt; i++)
{
    sb.Append(new String('.', n * 2 - 2));

    if (i == cnt / 2)
    {
        string dance = "D^A^N^C^E^";
        int sideSize = (n + 4 - dance.Length) / 2;
        sb.Append(new String('.', sideSize));
        sb.Append(new String(dance));
        sb.Append(new String('.', sideSize));
    }
    else
    {
        sb.Append(new String('#', n + 4));
    }

    sb.Append(new String('.', n * 2 - 2));
    sb.AppendLine();

}

Console.WriteLine(sb);
