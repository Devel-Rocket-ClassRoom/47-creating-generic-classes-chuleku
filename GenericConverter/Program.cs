using System;
using System.Linq;
using System.Security.Cryptography;
Converter<string, int> stringConverter = new Converter<string, int>(s => s.Length);
Console.WriteLine("=== 문자열 -> 길이 변환 ===");
string[] word = { "Hello", "World", "C#" };
int[] wordlength = stringConverter.ConvertAll(word);
Console.WriteLine($"Hello -> {stringConverter.Convert(word[0])}");
Console.Write("전체 변환: ");
string result = string.Join(", ", wordlength);
Console.Write(result);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("=== 정수 -> 문자열 변환 ===");
Converter<int,int> intconverter = new Converter<int,int>(i=>i);
int[] numbers = { 1, 2, 3 };
Console.WriteLine($"1 -> {intconverter.Convert(numbers[0])}번");
int[] number = intconverter.ConvertAll(numbers);
string result2 = string.Join(", ", number.Select(n =>n + "번"));
Console.Write("전체 변환: ");
Console.Write(result2);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("=== 실수 -> 정수 변환 ===");
Converter<float, int> floatconverter = new Converter<float, int>(f => (int)f);
float[] floatnumbers = { 3.7f, 1.2f, 9.9f };
Console.WriteLine($"3.7 -> {floatconverter.Convert(floatnumbers[0])}");
int[] floatnum = floatconverter.ConvertAll(floatnumbers);
string result3 = string.Join(", ", floatnum);
Console.Write("전체 변환: ");
Console.Write(result3);



