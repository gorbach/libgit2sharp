﻿using System.Linq;
                var commit = repo.Lookup("32eab9cb1f450b5fe7ab663462b77d7f4b703344", GitObjectType.Commit) as Commit;
                Tree commitTree = commit.Tree;
                Tree parentCommitTree = commit.Parents.Single().Tree;
                Assert.Equal("1/branch_file.txt", changes.Added.Single().Path);
                Assert.Equal(new[] { "1.txt", "1/branch_file.txt", "README", "branch_file.txt", "deleted_staged_file.txt", "deleted_unstaged_file.txt", "modified_staged_file.txt", "modified_unstaged_file.txt", "new.txt" },