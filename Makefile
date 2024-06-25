pulumi-run:
	az account set --subscription "SRE playground"
	az account show -o table
	