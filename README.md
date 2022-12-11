# katas

Here we have five different katas which can be run as console apps. 

1/5 Climbing Stairs Console App
-------------------------------

You are climbing a staircase. It takes n steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

Example 1:

Input: n = 2 
Output: 2 
Explanation: There are two ways to climb to the top.

1 step + 1 step
2 steps

Example 2:

Input: n = 3 
Output: 3 
Explanation: There are three ways to climb to the top.

1 step + 1 step + 1 step
1 step + 2 steps
2 steps + 1 step

Constraints:

1 <= n <= 45

2/5 Validate Binary Search Tree Console App
-------------------------------------------

Given the root of a binary tree, determine if it is a valid binary search tree (BST).

A valid BST is defined as follows:

The left subtree of a node contains only nodes with keys less than the node's key. The right subtree of a node contains 
only nodes with keys greater than the node's key. Both the left and right subtrees must also be binary search trees.

Example 1:

Input: root = [2,1,3] 
Output: true

Example 2:

Input: root = [5,1,4,null,null,3,6] 
Output: false 
Explanation: The root node's value is 5 but its right child's value is 4.

Constraints:

The number of nodes in the tree is in the range [1, 104]. -231 <= Node.val <= 231 - 1

3/5 Longest Common Prefix Console App
-------------------------------------

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

Example 1:

Input: strs = ["flower","flow","flight"] 
Output: "fl"

Example 2:

Input: strs = ["dog","racecar","car"] 
Output: "" 
Explanation: There is no common prefix among the input strings.

Constraints:

1 <= strs.length <= 200 0 <= strs[i].length <= 200 strs[i] consists of only lowercase English letters.

4/5 Merge Two Sorted Lists Console App
--------------------------------------

You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

Example 1:

Input: list1 = [1,2,4], list2 = [1,3,4] 
Output: [1,1,2,3,4,4]

Example 2:

Input: list1 = [], list2 = [] 
Output: []

Example 3:

Input: list1 = [], list2 = [0] 
Output: [0]

Constraints:

The number of nodes in both lists is in the range [0, 50]. -100 <= Node.val <= 100 Both list1 and list2 are sorted in non-decreasing order.

5/5 Reverse Linked List Console App 
-----------------------

Given the head of a singly linked list, reverse the list, and return the reversed list.

Example 1:

Input: head = [1,2,3,4,5] 
Output: [5,4,3,2,1]

Example 2:

Input: head = [1,2] 
Output: [2,1]

Example 3:

Input: head = [] 
Output: []

Constraints:

The number of nodes in the list is the range [0, 5000]. -5000 <= Node.val <= 5000
