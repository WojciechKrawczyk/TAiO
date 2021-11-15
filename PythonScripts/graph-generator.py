import numpy as np
import networkx as nx
import sys
import random

def GenerateGraph(n):
    p = random.randrange(20,100)
    graph=nx.gnp_random_graph(n,p/100)
    return nx.to_numpy_array(graph)

def GenerateTextFileFromTwoGraphs(G1,G2, name_of_file):
    size=str(G1.shape[0])
    file=open(name_of_file,'w')
    
    file.write(size)
    file.write('\n')
    for line in G1:
        for number in line:
            file.write(str(int(number)))
            file.write(' ')
        file.write('\n')

    file.write(size)
    file.write('\n')

    for line in G2:
        for number in line:
            file.write(str(int(number)))
            file.write(' ')
        file.write('\n')

    file.close()

def init():
    number_of_files=sys.argv[1]
    nodes=int(sys.argv[2])

    for i in range(int(number_of_files)):
        filename="test"+str(i)+".txt"
        GenerateTextFileFromTwoGraphs(GenerateGraph(nodes),GenerateGraph(nodes),filename)

init()