# 🚀 LeetCode Training Repository

Repositório dedicado aos meus exercícios e soluções de problemas do LeetCode, com foco principal em **C#**.

## 📋 Sobre

Este repositório contém minhas soluções para problemas do LeetCode, desenvolvidas como parte do meu treinamento em algoritmos e estruturas de dados. O foco principal é em C#, fortalecendo habilidades em .NET e programação orientada a objetos.

## 📁 Estrutura do Projeto

```
├── easy/
│   ├── 001-TwoSum/
│   │   ├── Program.cs
│   │   └── TwoSum.csproj
│   ├── 009-PalindromeNumber/
│   │   ├── Program.cs
│   │   └── PalindromeNumber.csproj
│   └── 013-RomanToInteger/
│       ├── Program.cs
│       └── RomanToInteger.csproj
├── medium/
│   ├── 002-AddTwoNumbers/
│   │   ├── Program.cs
│   │   └── AddTwoNumbers.csproj
│   └── 003-LongestSubstring/
│       ├── Program.cs
│       └── LongestSubstring.csproj
├── hard/
│   ├── 004-MedianOfTwoSortedArrays/
│   │   ├── Program.cs
│   │   └── MedianOfTwoSortedArrays.csproj
│   └── 023-MergeKSortedLists/
│       ├── Program.cs
│       └── MergeKSortedLists.csproj
├── .gitignore
└── README.md
```

## 🎯 Objetivos

- Melhorar habilidades de resolução de problemas algorítmicos
- Dominar estruturas de dados e padrões de design
- Aprimorar conhecimentos em C# e .NET
- Manter consistência e disciplina nos estudos
- Preparação para entrevistas técnicas

## 📊 Progresso

| Dificuldade | Total |
|-------------|-------|
| Easy        | 0     |
| Medium      | 0     |
| Hard        | 0     |
| **Total**   | **0** |

## 🔧 Tecnologias

- **C#** (.NET 8+)
- **Visual Studio Code** / **Visual Studio 2022**

## 📝 Padrão de Nomenclatura

Cada problema tem sua própria pasta seguindo o padrão:
```
[numero]-[NomeDoProblema]/
├── Program.cs
└── [NomeDoProblema].csproj
```

Exemplos:
- `001-TwoSum/`
- `015-ThreeSum/`
- `206-ReverseLinkedList/`

**Importante:** Use PascalCase no nome (primeira letra de cada palavra maiúscula) e mantenha o nome em inglês como aparece no LeetCode.

## 🚀 Como Executar

Para rodar um exercício específico:

```bash
# Navegue até a pasta do problema
cd easy/001-TwoSum

# Execute o projeto
dotnet run
```

## 📦 .gitignore Recomendado

Adicione no seu `.gitignore`:
```
bin/
obj/
*.user
.vs/
.vscode/
*.suo
*.userosscache
*.sln.docstates
```

## 💡 Estrutura de Cada Solução

Cada `Program.cs` contém:
- Descrição do problema (comentário)
- Link para o problema no LeetCode
- Análise de complexidade (tempo e espaço)
- Classe Solution com a implementação
- Método Main com exemplos de teste

Exemplo:
```csharp
/*
 * Problem: Two Sum
 * Link: https://leetcode.com/problems/two-sum/
 * Difficulty: Easy
 * 
 * Description:
 * Given an array of integers nums and an integer target,
 * return indices of the two numbers that add up to target.
 * 
 * Time Complexity: O(n)
 * Space Complexity: O(n)
 */

public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        var map = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            
            if (map.ContainsKey(complement))
                return new int[] { map[complement], i };
            
            map[nums[i]] = i;
        }
        
        return new int[] { };
    }
}

class Program
{
    static void Main(string[] args)
    {
        var solution = new Solution();
        
        // Test Case 1
        int[] nums1 = { 2, 7, 11, 15 };
        int target1 = 9;
        int[] result1 = solution.TwoSum(nums1, target1);
        Console.WriteLine($"Input: nums = [{string.Join(",", nums1)}], target = {target1}");
        Console.WriteLine($"Output: [{string.Join(",", result1)}]");
        Console.WriteLine();
        
        // Test Case 2
        int[] nums2 = { 3, 2, 4 };
        int target2 = 6;
        int[] result2 = solution.TwoSum(nums2, target2);
        Console.WriteLine($"Input: nums = [{string.Join(",", nums2)}], target = {target2}");
        Console.WriteLine($"Output: [{string.Join(",", result2)}]");
    }
}
```

## 📋 Template de .csproj

Cada projeto usa o seguinte template:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <RootNamespace>LeetCode</RootNamespace>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```

## 📈 Tópicos Estudados

- [ ] Arrays & Hashing
- [ ] Two Pointers
- [ ] Sliding Window
- [ ] Stack
- [ ] Binary Search
- [ ] Linked List
- [ ] Trees
- [ ] Tries
- [ ] Heap / Priority Queue
- [ ] Backtracking
- [ ] Graphs
- [ ] Dynamic Programming
- [ ] Greedy
- [ ] Intervals
- [ ] Math & Geometry
- [ ] Bit Manipulation

## 🤝 Contribuições

Este é um repositório pessoal de estudos, mas sugestões e feedbacks são sempre bem-vindos!

## 📫 Contato

Sinta-se à vontade para entrar em contato ou acompanhar meu progresso!

---

⭐ *Começado em: Outubro 2025*
