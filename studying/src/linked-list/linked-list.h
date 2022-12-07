//
// Created by tomas on 12/7/22.
//

#ifndef STUDYING_LINKED_LIST_H
#define STUDYING_LINKED_LIST_H

typedef struct node Node;

void insertAtBeginning(Node *head, int data);
void insertAtEnd(Node *head, int data);
void insertAtPosition(Node *head, int data, int pos);

#endif //STUDYING_LINKED_LIST_H
