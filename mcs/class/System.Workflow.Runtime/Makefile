thisdir = class/System.Workflow.Runtime
SUBDIRS = 
include ../../build/rules.make

LIBRARY = System.Workflow.Runtime.dll
LIB_REFS = 	System \
		System.Activities \
		System.Configuration \
		System.Core \
		System.Data \
		System.Design \
		System.EnterpriseServices \
		System.Messaging \
		System.Runtime.DurableInstancing \
		System.Runtime.Remoting \
		System.Runtime.Serialization \
		System.ServiceModel.Internals \
		System.Transactions \
		System.Web \
		System.Workflow.ComponentModel \
		Microsoft.CSharp \
		System.Xaml \
		System.Xml \
		System.Xml.Linq
LIB_MCS_FLAGS = /unsafe 
#/res:System.Activities.SR.resources /res:System.Activities.TD.resources

ifeq (true, $(GENERATE_RESOURCES))
LIB_MCS_FLAGS += /define:GENERATING_RESOURCES
endif

#RESX_RESOURCES = \
#		System.Activities.SR.resources \
#		System.Activities.TD.resources

CLEAN_FILES += $(RESX_RESOURCES)

RESOURCES = $(RESX_RESOURCES)

PREBUILT = $(RESX_RESOURCES:=.prebuilt)


TEST_MCS_FLAGS = $(LIB_MCS_FLAGS)

EXTRA_DISTFILES = more_build_args $(RESX_RESOURCES:.resources=.resx) $(PREBUILT)

include ../../build/library.make

$(the_lib): $(RESOURCES)

$(RESX_RESOURCES): %.resources: %.resx
	$(RESGEN) $< || cp $@.prebuilt $@

$(PREBUILT): %.prebuilt: %
	cp $* $@

dist-default: $(PREBUILT)

