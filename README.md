# TaintSQL: Dynamically Tracking Fine-Grained Implicit Flows for SQL Statements

## Authors
**Wei Lin, Lu Zhang, Haotian Zhang, Kailai Shao, Mingming Zhang, and Tao Xie.**

## Overall
**This work will be published in Proceedings of the 33rd IEEE International Conference on Software Reliability Engineering (ISSRE 2022), Charlotte, NC, October 2022.**

## Abstract
To address software engineering tasks such as security risk assessment, software change government, and access control in database applications, taint analysis approaches for SQL statements have been commonly adopted for tracking information flows in these applications.
However, existing taint analysis approaches cannot track implicit flows (i.e., control dependencies between sources and sinks) for SQL statements, facing the challenges of native/unmanaged code and database management system (DBMS) complexity.
To address these challenges, in this paper, we propose TaintSQL, a cell-level dynamic taint analysis (DTA) framework (maintaining a taint tag for each table cell) to track fine-grained implicit flows for SQL statements.
Our TaintSQL framework includes two novel techniques, namely MutaIF and MockIF.
MutaIF aims to track implicit flows with causal relationships, whereas MockIF aims to dynamically track implicit flows at runtime.
We implement the two techniques of TaintSQL and evaluate them on a set of test subjects to assess their effectiveness and efficiency.
The evaluation results show that both techniques effectively track fine-grained implicit flows for SQL statements with reasonable runtime overhead.
The F1 scores of MutaIF and MockIF are 96.2% and 97.9%, respectively.
We also conduct an industrial study of MutaIF in an international IT company (which serves over 1 billion global users and 80 million merchants).
The positive feedback from the software engineers also demonstrates the practicability of the TaintSQL framework and the MutaIF technique in industrial settings.

## Environment Requirements

1. MutaIF: JDK 1.8 or 11, developed with IntelliJ IDEA.
2. MockIF: .NET Framework 2, developed with Visual Studio 2010.

***Note: Due to the company's data protection policy, the source code released to the public here is regarded as a demonstration example of taint propagation tracking, not the real industrial-level code inside the company, and is for reference only.***
