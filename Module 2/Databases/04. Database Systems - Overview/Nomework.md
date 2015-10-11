# Database Systems Homework

*	Database models 
	*	Hierarchical  (tree)
	*	Network / graph
	*	Relational (table)
	*	Object-oriented

*	Relational databases manage data stored in tables
	*	Represent a bunch of tables together with the relationships between them 
	*	Rely on a strong mathematical foundation: the relational algebra
	*	support SQL

* Tables
	*	Database tables consist of data, arranged in rows and columns
	*	All rows have the same structure
	*	Columns have name and type (number, string, date, image, or other)
	
 * Primary Key vs. foreign key (PK/FK)
	*	Primary key is a column of the table that uniquely identifies its rows (usually its a number)

	* The foreign key is an identifier of a record located in another table (usually its primary key)

* Relationships
	* one-to-many - A single record in the first table has many corresponding records in the second table
	* any-to-many - Rcords in the first table have many correspon-ding records in the second one and vice versa

	* one-to-one - A single record in a table corresponds to a single record in the other table
	
* Normalization
    * Normalization involves decomposing a table into less redundant (and smaller) tables without losing information; defining foreign keys in the old table referencing the primary keys of the new ones. The objective is to isolate data so that additions, deletions, and modifications of an attribute can be made in just one table and then propagated through the rest of the database using the defined foreign keys.

* Integrity Constraints
    *	Integrity constraints ensure data integrity in the database tables - 	Enforce data rules which cannot be violated
    *	Primary key constraint - Ensures that the primary key of a table has unique value for each table row
    *	Unique key constraint - Ensures that all values in a certain column (or a group of columns) are unique
  	*	Foreign key constraint - Ensures that the value in given column is a key from another table
  	*	Check constraint - Ensures that values in a certain column meet some predefined condition

* Indexes
  	* Indexes speed up searching of values in a certain column or group of columns
	* Adding and deleting records in indexed tables is slower!

* SQL language
	 *	Standardized declarative language for manipulation of relational databases
	 *	Creating, altering, deleting tables and other objects in the database
	 *	Searching, retrieving, inserting, modifying and deleting table data (rows)

* Transactions
	*	Transactions are a sequence of database operations which are executed as a single unit:
	
	*	Example:
		*	A bank transfer from one account into another (withdrawal + deposit)
		*	If either the withdrawal or the deposit fails the entire operation should be cancelled


* NoSQL
	* Schema-free document storage
	* Still support CRUD operations
    * Create, Read, Update, Delete
    * Still support indexing and querying
    * Still supports concurrency and transactions
    * Highly optimized for append / retrieve
	* Great performance and scalability

* Non-Relational Data Models
    *	Document model (e.g. MongoDB, CouchDB) - Set of documents, e.g. JSON strings
    *	Key-value model (e.g. Redis) - Set of key-value pairs
    *	Hierarchical key-value - Hierarchy of key-value pairs
    *	Wide-column model (e.g. Cassandra) - Key-value model with schema
    *	Object model (e.g. Cache) - Set of OOP-style objects

* NoSQL Database Systems
    *	Redis - Ultra-fast in-memory data structures server
    *	MongoDB - Mature and powerful JSON-document database
    *	CouchDB - JSON-based document database with REST API
    *	Cassandra - Distributed wide-column database
