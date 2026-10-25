provider "aws" {
  region = "ap-south-1"
  access_key = "AKIA4MTWMJJZWRNEOBTW"
  secret_key = "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"
}

module "eks" {
  source  = "terraform-aws-modules/eks/aws"
  version = "~> 20.0"

  cluster_name    = "aspnet-windows-cluster"
  cluster_version = "1.31"

  vpc_id     = "vpc-07f379fdbf8a28da2" 
  subnet_ids = [
    "subnet-08c9a9ac5186f33a9", 
    "subnet-0f7e0d29e906ff1fc",
    "subnet-01449ae1f9d547d67",
    "subnet-054a78bd6c37ef5a5"
  ]

  eks_managed_node_groups = {
    linux_core = {
      min_size       = 1
      max_size       = 3
      desired_size   = 2
      instance_types = ["t3.medium"]
	  associate_public_ip_address = false 

    }
    
    windows_workers = {
      min_size       = 1
      max_size       = 3
      desired_size   = 2
      instance_types = ["m5.large"]
	  ami_type       = "WINDOWS_CORE_2022_x86_64" 
      associate_public_ip_address = false 
    }
  }
}
