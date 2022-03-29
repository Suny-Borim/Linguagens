#include <stdio.h>
#include <stdlib.h>

typedef struct Node {
	int val;
	char nome[60];
	struct Node* ini;
	struct Node* fim;
	struct Node* next;
	struct Node* prev;
}node;

void add(node* base);
void imprimeRecursiva(node* base);
int main() {
	node* base = (node*)malloc(sizeof(node));
	base->next = NULL;

	int op;

	do {
		printf("\n\n  MENU\n");
		printf("  1 - Inserir  \n");
		printf("  2 - Exibir   \n");
		printf("   0 - Sair     \n");
		printf("\n");
		printf("Entre com a opcao desejada: ");
		scanf_s("%d", &op);

		switch (op)
		{
		case 1:
			add(base);
			break;
		case 2:
			imprimeRecursiva(base);
			break;
		}

	} while (op);

	return 0;
}

void add(node* base) {
	node* new = (node*)malloc(sizeof(node));
	node* aux = base->ini;
	if (base->next != NULL) {
		base->next = new;
		new->prev = new;
		base->ini = new;
	}
	while (aux->next != NULL) {
		aux->next = aux->next;
		if (aux->next == NULL) {
			printf("Qual o valor do novo no: ");
			scanf_s("%d", &new->val);
			printf("Qual o nome do podcast:");
			scanf_s("%s", new->nome, 60);
		}
	}
}


void imprimeRecursiva(node* base) {
	if (base->next != NULL) {
		printf("Valor:%d\nNome do podcast:", base->next->val);
			printf("%s", base->next->nome);
		imprimeRecursiva(base->next);
	}
	else return 0;
}
