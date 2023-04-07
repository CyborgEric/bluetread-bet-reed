#!/bin/bash

nswag swagger2tsclient /input:http://localhost:7285/swagger/v1/swagger.json /output:./src/app/api-client.ts
