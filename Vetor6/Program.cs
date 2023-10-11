int N = int.Parse(Console.ReadLine());

string[] nomes = new string[N];
int[] idades = new int[N];

for (int i = 0; i < N; i++) {
    string[] vet = Console.ReadLine().Split(' ');
    nomes[i] = vet[0];
    idades[i] = int.Parse(vet[1]);
}

int maiorIdade = idades[0];
int posicaoMaiorIdade = 0;

for (int i = 0; i < N; i++) {
    if (idades[i] > maiorIdade) {
        maiorIdade = idades[i];
        posicaoMaiorIdade = i;
    }
}

Console.WriteLine("Pessoa mais velha: " + nomes[posicaoMaiorIdade]);