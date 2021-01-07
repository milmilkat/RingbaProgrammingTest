# How To Run
- You can set the Array to be searched for, the number of Threads, and the value needed to be searched for which is called ID.

## Considerations
- Since it was not mentioned the value should be searched in what type of data structure, I considered it to be a simple array in order to not to use any extra libraries as the task asked for, but it can be extended to other data structures easily.
- Based on the capacity of the running system, the number of threads can be changed and be optimised.
- Extra memory is just needed to keep indexes where to start a new thread on the original array, without creating multiple copies of the original array
- I thought maybe the array would be ordered; therefore, I created two methods: one for an ordered array, one for an unordered array.
- The ordered one can be a little bit faster
