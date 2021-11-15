import numpy as np
import networkx as nx
import sys

def readGraphs(csvGraphs):
    numbers=csvGraphs.split(",")
    size= int(numbers[0])
    numbers.remove(str(size))
    i=0
    j=0
    G1=np.zeros((size,size))
    G2=np.zeros((size,size))
    for number in numbers:
        if(i<size*size):
            G1[i%size][j%size]=int(number)
            i+=1
            if(i%size==0):
                j+=1
        else:
            G2[i%size][j%size]=int(number)
            i+=1
            if(i%size==0):
                j+=1
    return G1,G2

def init():
    csvGraph=sys.argv[1]
    G1,G2=readGraphs(csvGraph)
    print(nx.graph_edit_distance(nx.from_numpy_array(G1),nx.from_numpy_array(G2)))

init()