.PHONY: pulumi-req
pulumi-req:
	@echo "\nAzure Account setup: "
	az account set --subscription "SRE playground"
	az account show -o table
	@echo "dotnet version: \n"
	dotnet --version

.PHONY: pulumi-up
pulumi-up:  pulumi-req
	@echo "\nrunning pulumi: "
	pulumi up
