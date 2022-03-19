<template>
  <div class="tabs">
    <button
      class="tabs__tab"
      :class="{
        'tabs__tab--active': tab == props?.activeTab,
      }"
      v-for="(tab, idx) in props.tabs"
      :key="idx"
      @click="switchTab(tab)"
    >
      {{ tab }}
    </button>
  </div>
</template>

<script>
export default {
  name: "Tabs",
};
</script>

<script setup>
import { defineProps, defineEmits } from "vue";
const props = defineProps({
  tabs: {
    type: Array,
    required: true,
  },
  activeTab: {
    type: String,
    required: true,
  }
});
const emits = defineEmits(["apply:tab"]);
const switchTab = (_tab) => {
  emits("apply:tab", _tab);
};
</script>

<style scoped lang="scss">
.tabs {
  border-radius: 5px;
  display: flex;
  flex-wrap: wrap;
  &__tab {
    background: transparent;
    color: var(--black300);
    outline: none;
    border: 1px solid var(--black300);
    cursor: pointer;
    white-space: nowrap;
    padding: 10px;
    &:first-child {
      border-top-left-radius: 5px;
      border-bottom-left-radius: 5px;
    }
    &:last-child {
      border-top-right-radius: 5px;
      border-bottom-right-radius: 5px;
    }
    &:not(:last-child) {
      border-right: 1px solid var(--black300);
    }
    &:hover {
      opacity: 0.8;
    }
    &--active {
      background-color: var(--black25);
      color: var(--black900);
    }
  }
}
</style>
