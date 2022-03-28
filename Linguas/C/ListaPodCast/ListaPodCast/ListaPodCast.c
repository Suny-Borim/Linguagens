#include <stdio.h>
#include <stdlib.h>

typedef struct Node {
	int val;
	int id;
	char nome[50];
	struct Node* next;
}node;

void add(node* base);
void remover(node* base);
void mostrar(node* base);

int main() {
	node* base = (node*)malloc(sizeof(node));
	base->next = NULL;
	base->id = 0;

	int escolha;

	do {
		printf("1 - Inserir\n");
		printf("2 - Exibir\n");
		printf("0 - Sair\n");
		printf("Que que tu quer?\n");
		scanf_s("%d", &escolha);

		switch (escolha)
		{
		case 1:
			add(base);
			break;

		case 2:
			mostrar(base);
			break;

		}

	} while (escolha);

	return 0;
}

void add(node* base) {
	node* novo = (node*)malloc(sizeof(node));
	node* proximo = (node*)malloc(sizeof(node));
	node* aux = base;
	proximo = aux->next;
	do {
		if (aux->next == NULL) {
			printf("Qual o valor do novo:\n");
			scanf_s("%d", &novo->val);
			aux->next = novo;
			base = aux;
			return 0;
		}
		aux = proximo->next;
		proximo = proximo->next;
	} while (aux != NULL);
}

void remover(node* base) {
	node* ante = base;
	node* aux = base;
	int remover;

	printf("Entre com o valor a ser removido: ");
	scanf_s("%d", &remover);

	while (aux->next != NULL) {
		ante = aux;
		aux = aux->next;
		if (aux->val == remover) {
			ante->next = aux->next;
			printf("O valor %d foi removido. \n", remover);
			return;
		}
	}
	printf("O valor %d nao existe na lista. \n", remover);
}

void mostrar(node* base) {
	node* aux = base;
	printf("-%d", aux->val);
	mostrar(aux->next);
}

