import numpy as np
import networkx as nx
from scipy.optimize import linear_sum_assignment
import sys

def addEdge(G, i, j):
    G[i][j] = 1
    G[j][i] = 1
    return G


def createSubgraphNew(G, n, h):
    if(h < 1):
        raise Exception("glebokosc podgrafu musi byc przynajmniej 1")
    subGraph = np.zeros(G.shape)
    depth = 1

    tmp = list()
    for i in range(G.shape[0]):
        if(G[n][i] == 1):
            subGraph = addEdge(subGraph, n, i)
            tmp.append(i)

    while(True):
        depth += 1
        if(depth > h):
            break
        tmp2 = list()
        for vertex in tmp:
            for i in range(G.shape[0]):
                if(G[vertex][i] == 1):
                    subGraph = addEdge(subGraph, vertex, i)
                    tmp2.append(i)

        depth += 1
        if(depth > h):
            break
        tmp = list()
        for vertex in tmp2:
            for i in range(G.shape[0]):
                if(G[vertex][i] == 1):
                    subGraph = addEdge(subGraph, vertex, i)
                    tmp.append(i)

    return subGraph

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

def dist(C,Phi):
    res = 0
    for i in range(C.shape[0]):
        res += C[i, Phi[1][i]]
    return res

def exactDist(G1,G2):
    return nx.graph_edit_distance(nx.from_numpy_array(G1),nx.from_numpy_array(G2))

def zbadajPodobienstwoLSAP(G1,G2):
    subgraphsG1 = []
    subgraphsG2 = []
    for i in range(G1.shape[0]):
        subgraphsG1.append(createSubgraphNew(G1, i, 3))
        subgraphsG2.append(createSubgraphNew(G2, i, 3))

    C= np.zeros(G1.shape)
    for i in range(G1.shape[0]):
        for j in range(G2.shape[0]):
            C[i][j]=exactDist(subgraphsG1[i],subgraphsG2[j])
    Phi=linear_sum_assignment(C)

    return dist(C, Phi)/C.shape[0]


def init():
    csvGraph = sys.argv[1]
    G1, G2 = readGraphs(csvGraph)

    dystans = zbadajPodobienstwoLSAP(G1, G2)
    print(dystans)
init()
