
import os, csv
from pathlib import Path 

csv_file_path = Path("Module_Challenge_3", "PyPoll", "election_data.csv")
 
total_votes = 0 
Charles_Casper_Votes = 0
Diana_DeGette_Votes = 0
Raymon_Anthony_Doane_votes = 0

with open(csv_file_path,newline="", encoding="utf-8") as candidates:

    csvreader = csv.reader(candidates,delimiter=",") 

    header = next(csvreader)     

    for row in csvreader: 

        total_votes +=1

        if row[2] == "Charles Casper": 
            Charles_Casper_Votes +=1
        elif row[2] == "Diana DeGette":
            Diana_DeGette_Votes +=1
        elif row[2] == "Raymon Anthony Doane": 
            Raymon_Anthony_Doane_votes  +=1


candidates = ["Charles Casper", "Diana DeGette", "Raymon Anthony Doane"]
votes = [Charles_Casper_Votes, Diana_DeGette_Votes,Raymon_Anthony_Doane_votes]

dict_candidates_and_votes = dict(zip(candidates,votes))
key = max(dict_candidates_and_votes, key=dict_candidates_and_votes.get)

Charles_Casper_percent = (Charles_Casper_Votes/total_votes) *100
Diana_DeGette_percent = (Diana_DeGette_Votes/total_votes) * 100
Raymon_Anthony_Doane_percent = (Raymon_Anthony_Doane_votes)* 100

print(f"Election Results")
print(f"----------------------------")
print(f"Total Votes: {total_votes}")
print(f"----------------------------")
print(f"Charles Casper: {Charles_Casper_percent:.3f}% ({Charles_Casper_votes})")
print(f"Diana DeGette: {Diana_DeGette_percent:.3f}% ({Diana_DeGette_votes})")
print(f"Raymon Anthony Doane: {Raymon_Anthony_Doane_percent:.3f}% ({Raymon_Anthony_Doane_votes})")
print(f"----------------------------")
print(f"Winner: {key}")
print(f"----------------------------")

output_file = Path("Module_Challenge_3", "PyPoll", "PYPOLL_RESULTS.txt")

with open(output_file,"w") as file:
 
    file.write(f"Election Results")
    file.write("\n")
    file.write(f"----------------------------")
    file.write("\n")
    file.write(f"Total Votes: {total_votes}")
    file.write("\n")
    file.write(f"----------------------------")
    file.write("\n")
    file.write(f"Charles Casper: {Charles_Casper_percent:.3f}% ({Charles_Casper_votes})")
    file.write("\n")
    file.write(f"Diana DeGette: {Diana_DeGette_percent:.3f}% ({Diana_DeGette_votes})")
    file.write("\n")
    file.write(f"Raymon Anthony Doane: {Raymon_Anthony_Doane_percent:.3f}% ({Raymon_Anthony_Doane_votes})")
    file.write("\n")
    file.write(f"----------------------------")
    file.write("\n")
    file.write(f"Winner: {key}")
    file.write("\n")
    file.write(f"----------------------------")



