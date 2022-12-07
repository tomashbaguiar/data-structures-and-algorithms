//
// Created by tomas on 12/7/22.
//

#include "array.h"

int
array_search(int *array, int n, int key) {
    for (int i = 0; i < n; i++)
    {
        if (array[i] == key) return i;
    }

    return -1;
}