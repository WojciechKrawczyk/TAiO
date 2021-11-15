import numpy as np
import networkx as nx
from scipy.optimize import linear_sum_assignment
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

def createSubgraph(G,vertex,depth):
    n = vertex[0]*G.shape[0] + vertex[1]
    subGraph = nx.ego_graph(nx.from_numpy_array(G), n, depth)
    return nx.to_numpy_array(subGraph)

def dist(C,Phi):
    res = 0
    for row in C:
        res += C[row,Phi[row]]
    for i in range(C.shape.row):
        for j in range(i+1, C.shape.row + 1):
            print() # res += c((vi, vj) -> (vi',vj'))
    return res

def exactDist(G1,G2):
    return nx.graph_edit_distance(nx.from_numpy_array(G1),nx.from_numpy_array(G2))

def zbadajPodobienstwoLSAP(G1,G2):
    C= np.zeros(G1.shape)

    for i in range(G1.shape[0]):
        for j in range(G2.shape[0]):
            subgraphG1=createSubgraph(G1, (i,j),3)
            subgraphG2=createSubgraph(G2, (i,j),3)
            print(exactDist(subgraphG1,subgraphG2))
            C[i][j]=exactDist(subgraphG1,subgraphG2)

    Phi=linear_sum_assignment(C)

    return dist(C, Phi)


def init():
    csvGraph=sys.argv[1]
    G1,G2=readGraphs(csvGraph)

    dystans = zbadajPodobienstwoLSAP(G1,G2)
    print(dystans)


init()