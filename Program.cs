//*****************************************************************************
//** 23. Merge k Sorted Lists                                                **
//** My brain is numb after what I thought would be simple                   **
//** I think I hate pointers.                                                **
//*****************************************************************************
//*****************************************************************************
/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     struct ListNode *next;
 * };
 */
struct ListNode* mergeKLists(struct ListNode** lists, int listsSize) {
    struct ListNode* nlist = NULL;
    struct ListNode* temptr = NULL;
    int leastval;
    int index;
    int nsize = 0;
    int sign;
    while(nsize < listsSize)
    {
        sign = 0;
        for(int i = 0; i < listsSize; i++)
        {
            if(lists[i] == NULL)
            {
                continue;
            }
            else
            {
                if(sign == 0)
                {
                    leastval = lists[i]->val;
                    index = i;
                    sign = 1;
                }
                else
                {
                    if(lists[i] ->val < leastval)
                    {
                        leastval = lists[i] ->val;
                        index = i;
                    }
                }
            }
        }
        if(sign == 0)
        {
            break;
        }
        if(nlist)
        {
            temptr ->next = lists[index];
            temptr = temptr ->next;
            lists[index] = lists[index] ->next;
            if(lists[index] == NULL)
            {
                nsize++;
            }
        }
        else
        {
            nlist = lists[index];
            temptr = lists[index];
            lists[index] = lists[index] ->next;
            if(lists[index] == NULL)
            {
                nsize++;
            }
        }
    }
    return nlist;
}