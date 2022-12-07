//
// Created by tomas on 12/7/22.
//

#include "linked-list.h"

#include <stdlib.h>

struct node
{
    int data;
    struct node *next;
};


void
insertAtBeginning(Node *head, int data) {
    Node *newNode = (Node *) malloc(sizeof(Node));
    newNode->data = data;
    if (head == NULL)
    {
        newNode->next = NULL;
        head = newNode;
        return;
    }

    newNode->next = head;
    head = newNode;
}

void
insertAtEnd(Node *head, int data) {
    Node *newNode = (Node *) malloc(sizeof(Node));
    newNode->data = data;
    if (head == NULL)
    {
        newNode->next = NULL;
        head = newNode;
        return;
    }

    Node *node = head;
    while (node->next != NULL)
        node = node->next;
    node->next = newNode;
    newNode->next = NULL;
}

void
insertAt(Node *head, int data, int pos) {
    Node *newNode = (Node *) malloc(sizeof(Node));
    newNode->data = data;
    if (head == NULL)
    {
        newNode->next = NULL;
        head = newNode;
        return;
    }

    Node *node = head;
    int i = 0;
    while (i++ < pos) node = node->next;
    newNode->next = node->next;
    node->next = newNode;
}