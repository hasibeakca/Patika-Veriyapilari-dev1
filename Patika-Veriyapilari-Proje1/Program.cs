// Insertion Sort sıralaması : 
int[] dizi = {22, 27, 16, 2, 18, 6};
Console.WriteLine("Başlangıçtaki hali : ");
foreach (int i in dizi)
{
    Console.Write(i);
    Console.Write(" ");

}
InsertionSort(dizi);
Console.WriteLine("\nSıralanmış hali : ");



foreach(int i in dizi)
{
    Console.Write(i);
    Console.Write(" ");

}
// Sıralandıktan sonra aradığımız sayı (18) ortada yani average case.
//Big o notasyonu O(n^2)
static void InsertionSort(int[] dizi)
{
    int n = dizi.Length;
    for (int i = 1; i < n; ++i)
    {
        int x = dizi[i];
        int y = i - 1;

        while (y >= 0 && dizi[y] > x)
        {
            dizi[y + 1] = dizi[y];
            y = y - 1;

        }
        dizi[y + 1] = x;
    }
}


/* Selection Sort ilk 4 adım
Sırayla en küçük eleman bulunarak en başa yerleştirerek devam eder.
Dizimiz : [7,3,5,8,2,9,4,15,6]
1. Adım:
En küçük sayı "2". Bunu başa yerleştirdik ve sabit kıldık.
Dizinin yeni hali : [2,7,3,5,8,9,4,15,6].
2. Adım: 
2 sayısı hariç diğer sayılara baktık ve en küçük bulduk. "3" Bunu da 2. sıraya yerleştirdik ve sabit kıldık.
Dizinin yeni hali : [2,3,7,5,8,9,4,15,6].
3. Adım:
İlk iki elemanı sabit kıldık ve devamına baktık. en küçük sayı 4. Bunu da 3. sıraya yerleştirdik.
Dizinin yeni hali : [2,3,4,7,5,8,9,15,6].
4. Adım:
İlk üç elemanı sabit kıldık ve devamına baktık. en küçük sayı 5. Bunu da 4. sıraya yerleştirdik.
Dizinin yeni hali : [2,3,4,5,5,8,9,15,6].
*/